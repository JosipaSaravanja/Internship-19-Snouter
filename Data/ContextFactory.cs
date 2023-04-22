using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.IO;

namespace Data
{
    public class ShopContextFactory : IDesignTimeDbContextFactory<SnouterContext>
    {
        public IConfigurationRoot GetConnectionString()
        {
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.Development.json", true)
                .Build();
            return configurationBuilder;
        }
        public SnouterContext CreateDbContext(string[] args)
        {
            var connectionString = GetConnectionString()
                .GetConnectionString("Database"); // This is the connection string from appsettings.json

            var options = new DbContextOptionsBuilder<SnouterContext>()
                .UseNpgsql(connectionString)
                .Options;

            return new SnouterContext(options);
        }
    }
}