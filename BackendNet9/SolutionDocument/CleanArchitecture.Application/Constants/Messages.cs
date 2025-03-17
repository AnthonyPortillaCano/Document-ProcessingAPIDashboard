namespace CleanArchitecture.Application.Constants
{
    public class Messages
    {
        public const string TRANSACTION_SUCCESS = "Transaccion Exitosa";
        public const string ERROR_TRANSACTION = "Error en la transaccion";
        public const string CODE_ERROR = "0000";
        public const string CODE_SUCCESS = "1111";
        public const string TRANSACTION_SUCCESS_FILE = "File processed successfully.";
        public const string NoFileUploaded = "No file uploaded.";
        public const string NoCsvFound = "No CSV file found in ZIP.";
        public const string SaveFailed = "Failed to save data.";
        public const string FileProcessingError = "Error processing file";
        public const string NoDocumentsFound = "No documents found.";
        public const string DocumentRetrievalError = "Error retrieving document";
        public const string DocumentNotFound = "Document with ID {0} not found.";
        public const string InvalidFileType = "Invalid file type. Please upload a ZIP file.";
    }
}
