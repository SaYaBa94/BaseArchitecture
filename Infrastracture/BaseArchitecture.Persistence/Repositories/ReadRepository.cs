using BaseArchitecture.Application.Repositories;
using BaseArchitecture.Domain.Entities.Common;
using BaseArchitecture.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BaseArchitecture.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity 
    {
        private readonly BaseArchitectureAPIDbContext _context;

        public ReadRepository(BaseArchitectureAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
        {
            return Table;
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return Table.Where(expression);
        }

        public async Task<T> GetAsync(string id)
        {
            return await Table.FirstOrDefaultAsync(entity => entity.Id ==  Guid.Parse(id));
        }


        public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return await Table.FirstOrDefaultAsync(expression);
        }
    }
}
