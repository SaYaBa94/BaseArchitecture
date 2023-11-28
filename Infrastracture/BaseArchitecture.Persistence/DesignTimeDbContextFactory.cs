using BaseArchitecture.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BaseArchitecture.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BaseArchitectureAPIDbContext>
    {
        public BaseArchitectureAPIDbContext CreateDbContext(string[] args)
        {
           
            DbContextOptionsBuilder<BaseArchitectureAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
