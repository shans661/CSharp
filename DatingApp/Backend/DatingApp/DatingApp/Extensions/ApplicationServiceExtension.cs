using DatingApp.API;
using DatingApp.API.Helpers;
using DatingApp.Helpers;
using DatingApp.Interfaces;
using DatingApp.Repository;
using DatingApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace DatingApp.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config )
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DatingApp", Version = "v1" });
            });
            
            services.AddDbContext<DataBaseContext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(AutomapperProfiles).Assembly);
            services.Configure<CloudinarySettings>(config.GetSection("CloudinarySettings"));
            services.AddScoped<IPhotoService, PhotoService>();
            services.AddScoped<LogUserActivity>();
            services.AddScoped<ILikesRepository, LikesRepository>();

            return services;
        }
    }
}