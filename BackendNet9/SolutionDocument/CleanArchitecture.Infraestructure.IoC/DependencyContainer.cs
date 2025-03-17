using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infraestructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IUnitOfWork>(options => new UnitOfWork(new DocumentDbContext(new DbContextOptionsBuilder<DocumentDbContext>().UseSqlServer(configuration.GetConnectionString("ConnectionSqlServer")).Options)));
        }
    }
}
