using CleanArchitecture.Application.Constants;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Models;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.IO.Compression;

namespace CleanArchitecture.MinimalApi
{
    public static class DocumentEndpoints
    {
        public static RouteGroupBuilder MapDocumentRoutes(this WebApplication app)
        {
            var group = app.MapGroup("Api/Document").DisableAntiforgery();

            group.MapPost("/upload", HandleFileUpload);
            group.MapGet("/documents", GetAllDocuments);
            group.MapGet("/documents/{id}", GetDocumentById);

            return group;
        }

        private static async Task<IResult> HandleFileUpload([FromForm] IFormFile file, IUnitOfWork unitOfWork)
        {
            try
            {
                if (file == null || file.Length == 0)
                    return Results.BadRequest(Messages.NoFileUploaded);

                if (!file.ContentType.Equals("application/x-zip-compressed", StringComparison.OrdinalIgnoreCase))
                    return Results.BadRequest(Messages.InvalidFileType);

                var extractedData = await ExtractCsvFromZip(file);
                if (extractedData == null || !extractedData.Any())
                    return Results.BadRequest(Messages.NoCsvFound);

                await unitOfWork.documentServices.InsertList(extractedData);
                int result = await unitOfWork.CommitAsync();
                if (result == 0) return Results.BadRequest(Messages.SaveFailed);

                return Results.Ok(new ResponseTransaccionDto
                {
                    Result = Messages.CODE_SUCCESS,
                    Description = Messages.TRANSACTION_SUCCESS_FILE
                });
            }
            catch (Exception ex)
            {
                return Results.BadRequest($"{Messages.FileProcessingError}: {ex.Message}");
            }
        }

        private static async Task<List<Document>?> ExtractCsvFromZip(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                throw new ArgumentException("El archivo no puede ser nulo o vacío.");
            }
            var tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(tempDir);

            try
            {
                var filePath = Path.Combine(tempDir, file.FileName);
                await using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    await file.CopyToAsync(stream);
                }

                ZipFile.ExtractToDirectory(filePath, tempDir);

                var csvFile = Directory.GetFiles(tempDir, "*.csv").FirstOrDefault();
                if (csvFile == null)
                {
                    throw new FileNotFoundException("No se encontró ningún archivo CSV en el archivo ZIP.");
                }

                using var reader = new StreamReader(csvFile);
                using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ",", 
                    MissingFieldFound = null, 
                    HeaderValidated = null 
                });

                csv.Context.RegisterClassMap<DocumentMap>();

                var records = csv.GetRecords<Document>().ToList();

                return records;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al procesar el archivo ZIP o CSV.", ex);
            }
            finally
            {
                if (Directory.Exists(tempDir))
                {
                    Directory.Delete(tempDir, true);
                }
            }
        }

        private static async Task<IResult> GetAllDocuments(IUnitOfWork unitOfWork)
        {
            try
            {
                var documents = await unitOfWork.documentServices.GetDocuments();
                return documents.Count > 0 ? Results.Ok(documents) : Results.NotFound(Messages.NoDocumentsFound);
            }
            catch (Exception ex)
            {
                return Results.BadRequest($"{Messages.DocumentRetrievalError}: {ex.Message}");
            }
        }

        private static async Task<IResult> GetDocumentById(int id, IUnitOfWork unitOfWork)
        {
            try
            {
                var document = await unitOfWork.documentServices.GetDocumentById(id);
                return document != null ? Results.Ok(document) : Results.NotFound(string.Format(Messages.DocumentNotFound, id));
            }
            catch (Exception ex)
            {
                return Results.BadRequest($"{Messages.DocumentRetrievalError}: {ex.Message}");
            }
        }
    }
}
