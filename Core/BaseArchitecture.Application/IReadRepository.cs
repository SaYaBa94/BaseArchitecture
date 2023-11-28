using BaseArchitecture.Domain.Entities.Common;
using System.Linq.Expressions;

namespace BaseArchitecture.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T,bool>> expression);
        Task<T> GetAsync(string id);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);


    }
}
