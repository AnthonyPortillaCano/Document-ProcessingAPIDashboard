using System.Linq.Expressions;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IRepositoryEF<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        void Update(T entity);
        void Insert(T entity);
        Task Delete(Expression<Func<T, bool>> condicion);
        Task<T> Obtener<T>(Expression<Func<T, bool>> condicion) where T : class;
        Task<List<T>> ObtenerList<T>(Expression<Func<T, bool>> condicion) where T : class;
        void UpdateFieldsSave(T entity, params Expression<Func<T, object>>[] includeProperties);
        void DeleteList(List<T> entity);
        Task InsertList(List<T> values);
    }
}
