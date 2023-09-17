using Microsoft.EntityFrameworkCore;
using Zzzaikin.MedicinesAtHome.Integration;
using Zzzaikin.MedicinesAtHome.Integration.Medicines;

namespace Zzzaikin.MedicinesAtHome.DataService
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var services = builder.Services;
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddDbContext<AppDbContext>((options) =>
            {
                var dbConnectionString = builder.Configuration.GetConnectionString("DbConnectionString");
                options.UseNpgsql(dbConnectionString);
            });

            services.AddSingleton<IMedicinesIntegrationParser, PharmacyMedsiParser>();
            
            services.AddSingleton<IMedicinesIntegrator, MedicinesIntegrator>(serviceProvider => 
            {
                var intagrationParser = serviceProvider.GetRequiredService<IMedicinesIntegrationParser>();
                return new MedicinesIntegrator(intagrationParser);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}