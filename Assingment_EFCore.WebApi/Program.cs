using Assingment_EFCore.Application.Core.Services;
using Assingment_EFCore.Infrastructure.Data;
using Assingment_EFCore.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

namespace Assingment_EFCore.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var appSettings = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true)
                .Build();
            builder.Services.AddDbContext<LibraryDbContext>();
            Application.DependencyInjections.ConfigureServices(builder.Services);
            Infrastructure.DependencyInjections.ConfigureServices(builder.Services, appSettings);
            builder.Services.AddDbContext<LibraryDbContext>(options =>
            {
                options.UseSqlServer(appSettings.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<ILoggerService, LoggerService>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.MapControllers();
            using (var scope = app.Services.CreateScope())
            {
                Infrastructure.DependencyInjections.MigrateDatabase(scope.ServiceProvider);
            }
            app.Run();
        }
    }
}