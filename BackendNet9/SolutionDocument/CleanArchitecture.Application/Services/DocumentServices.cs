using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infraestructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Services
{
    public class DocumentServices:IDocumentServices
    {
        protected IDocumentRepository _documentRepository;
        public DocumentServices(DbContext context)
        {
            _documentRepository = new DocumentRepository(context);
        }
        public async Task InsertList(List<Document> documents)
        {
           await  _documentRepository.InsertList(documents);
        }
        public async Task<List<Document>> GetDocuments()
        {
            return await _documentRepository.GetAll();
        }
        public async Task<Document> GetDocumentById(int id)
        {
            return await _documentRepository.GetById(id);
        }
    }
}
