using Microsoft.EntityFrameworkCore;

namespace BaseArchitecture.Persistence.Contexts
{
    public class BaseArchitectureAPIDbContext : DbContext
    {
        public BaseArchitectureAPIDbContext(DbContextOptions options) : base(options)
        {
            
        }
        //public DbSet<Product> Products { get; set; }
       

        
    }
}
