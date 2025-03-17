using CleanArchitecture.Domain.Models;
using CsvHelper.Configuration;

namespace CleanArchitecture.MinimalApi
{
    public class DocumentMap : ClassMap<Document>
    {
        public DocumentMap()
        {
            Map(m => m.PdfName).Name("PdfName");
            Map(m => m.FirstName).Name("FirstName");
            Map(m => m.LastName).Name("LastName");
            Map(m => m.Age).Name("Age");
            Map(m => m.Address).Name("Address");
            Map(m => m.Ssn).Name("Ssn");
            Map(m => m.UploadedAt)
                .Name("UploadedAt")
                .TypeConverterOption.Format("yyyy-MM-ddTHH:mm:ss.fffZ"); // Formato de fecha
        }
    }
}
