
using Domain.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Serialization;
using Data;
using Domain.Mappers;
using Domain.Repository;

namespace Domain
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddDbContext<SnouterContext>(options =>
            {
                options.UseNpgsql("Host=localhost;Database=snouter;Username=postgres;Password=postgres");
            });
            services.AddScoped<CategoryServices>();
            services.AddScoped<LocationServices>();
            services.AddScoped<CategoryServices>();
            services.AddScoped<UserServices>();
            services.AddScoped<SubCategoryServices>();
            services.AddScoped<UserRepository>();
            services.AddScoped<LocationRepository>();
            services.AddScoped<ProductsServices>();
            services.AddScoped<SubCategoryRepository>();
            services.AddScoped<CategoryRepository>();
            services.AddScoped<ProductRepository>();
            services.AddScoped <UserMappers>();
            services.AddScoped<CategoryMapper>();
            services.AddScoped<LocationMapper>();
            services.AddScoped<ProductsMapper>();
            services.AddScoped<SubCategoryMapper>();
            //add database
            return services;
        }
     

    }
}