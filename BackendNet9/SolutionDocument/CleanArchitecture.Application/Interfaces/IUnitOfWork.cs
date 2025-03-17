namespace CleanArchitecture.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IDocumentServices documentServices { get; }
        Task<int> CommitAsync();
    }
}
