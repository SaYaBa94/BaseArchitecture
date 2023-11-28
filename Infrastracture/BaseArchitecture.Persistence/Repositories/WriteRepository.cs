using BaseArchitecture.Application.Repositories;
using BaseArchitecture.Domain.Entities.Common;
using BaseArchitecture.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BaseArchitecture.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly BaseArchitectureAPIDbContext _context;

        public WriteRepository(BaseArchitectureAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(ICollection<T> entities)
        {
            await Table.AddRangeAsync(entities);
            return true;
        }

        public bool Update(T entity)
        {
            EntityEntry<T> entityEntry=Table.Update(entity);
            return entityEntry.State == EntityState.Modified;
        }

        public bool UpdateRange(ICollection<T> entities)
        {
            Table.UpdateRange(entities);
            return true;
        }

        public bool Remove(T entity)
        {
            EntityEntry<T> entityEntry = Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> Remove(string id)
        {
            T entity = await Table.FirstOrDefaultAsync(e => e.Id == Guid.Parse(id));
            return Remove(entity);
        }

        public bool RemoveRange(ICollection<T> entities)
        {
            Table.RemoveRange(entities);
            return true;
        }
        public async Task<int> SaveAsync()
        {
           return await _context.SaveChangesAsync();
        }

       
    }
}
