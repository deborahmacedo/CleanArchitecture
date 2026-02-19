using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Persistence.Context;
using CleanArchitecture.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Persistence
{
    //ela ser pública e estatica é um requisito para usar uym metodo de extensão
    public static class ServiceExtentions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Sqlite");
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(connectionString));
            services.AddScoped<IUnityOfWork, UnityOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
