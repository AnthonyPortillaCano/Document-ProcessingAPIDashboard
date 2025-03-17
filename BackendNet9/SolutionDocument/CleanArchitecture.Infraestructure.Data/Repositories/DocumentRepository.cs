using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infraestructure.Data.Repositories
{
    public class DocumentRepository : RepositoryEF<Domain.Models.Document>, IDocumentRepository
    {
        public DocumentRepository(DbContext context) : base(context)
        {
            repositoryEF = new RepositoryEF<Domain.Models.Document>(context);
        }
        public IRepositoryEF<Domain.Models.Document> repositoryEF { get; set; }
        public new async Task  InsertList(List<Domain.Models.Document> documents)
        {
             await repositoryEF.InsertList(documents);
        }
        public new async Task<List<Document>> GetAll()
        {
            return await repositoryEF.GetAll();
        }
        public new async  Task<Document> GetById(int id)
        {
            return await repositoryEF.GetById(id);
        }
    }
}
