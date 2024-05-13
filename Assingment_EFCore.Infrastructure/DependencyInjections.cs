using Assingment_EFCore.Application.Core.Services;
using Assingment_EFCore.Domain.Core.Repositories;
using Assingment_EFCore.Infrastructure.Data;
using Assingment_EFCore.Infrastructure.Repositories;
using Assingment_EFCore.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Assingment_EFCore.Infrastructure
{
    public static class DependencyInjections
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<LibraryDbContext>(options =>
               options.UseSqlServer(connectionString,
               x => x.MigrationsAssembly("Assingment_EFCore.Infrastructure")));
            services.AddScoped(typeof(IBaseRepositoryAsync<>), typeof(BaseRepositoryAsync<>));
            services.AddScoped<ILoggerService, LoggerService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static void MigrateDatabase(IServiceProvider serviceProvider)
        {
            var dbContextOptions = serviceProvider.GetRequiredService<DbContextOptions<LibraryDbContext>>();

            using (var dbContext = new LibraryDbContext(dbContextOptions))
            {
                dbContext.Database.Migrate();
            }
        }
    }
}