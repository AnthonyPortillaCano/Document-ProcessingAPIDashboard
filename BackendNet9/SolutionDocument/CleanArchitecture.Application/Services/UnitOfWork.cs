using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Infraestructure.Data.Context;

namespace CleanArchitecture.Application.Services
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly DocumentDbContext _context;
        public UnitOfWork(DocumentDbContext context)
        {
            _context = context;
            documentServices = new DocumentServices(context);
        }
        public IDocumentServices documentServices { get; private set; }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
