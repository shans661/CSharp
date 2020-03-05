using DBAccess.EFCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.API.Configurations
{
    public static class DataBaseServices
    {
        public static void AddDefiniteDatabase(this IServiceCollection services)
        {
            services.AddDbContext<ToDoListDBContext>(x => x.UseNpgsql(GetConnectionString()));
        }

        private static string GetConnectionString()
        {
            return $"Host={ConnectionString.host};Database={ConnectionString.Tenant};Username={ConnectionString.Name};Password={ConnectionString.Password};Port={ConnectionString.Port};";
        }
    }
}

