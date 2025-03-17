using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Interfaces
{
     public interface IDocumentRepository
    {
        Task InsertList(List<Domain.Models.Document> documents);
        Task<List<Document>> GetAll();
        Task<Document> GetById(int id);
    }
}
