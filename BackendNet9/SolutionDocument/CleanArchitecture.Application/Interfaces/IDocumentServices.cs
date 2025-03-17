using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IDocumentServices
    {
        Task InsertList(List<Document> documents);
        Task<List<Document>> GetDocuments();
        Task<Document> GetDocumentById(int id);
    }
}
