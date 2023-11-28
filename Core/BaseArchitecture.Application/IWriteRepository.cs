using BaseArchitecture.Domain.Entities.Common;

namespace BaseArchitecture.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(ICollection<T> entities);
        bool Update(T entity);
        bool UpdateRange(ICollection<T> entities);
        bool Remove(T entity);
        bool RemoveRange(ICollection<T> entities);
        Task<bool> Remove(string id);
        Task<int> SaveAsync();
    }
}
