using BaseArchitecture.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaseArchitecture.Application.Repositories;
using BaseArchitecture.Persistence.Repositories;

namespace BaseArchitecture.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<BaseArchitectureAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));

         

            //services.AddScoped<IProductReadRepository, ProductReadRepository>();
            //services.AddScoped<IProductWriteRepository, ProductWriteRepository>();

        }
    }
}
