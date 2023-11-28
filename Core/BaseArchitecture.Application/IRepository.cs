using BaseArchitecture.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace BaseArchitecture.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
