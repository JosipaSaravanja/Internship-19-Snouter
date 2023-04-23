using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace Data;

public static class Seeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var locations = new List<Location>
        {
            new Location
            {
                Id = Guid.NewGuid(),
                Name = "Breda",
                Latitude = 51.586849,
                Longitude = 4.776023,
            },

            new Location
            {
                Id = Guid.NewGuid(),
                Name = "Tilburg",
                Latitude = 51.555,
                Longitude = 5.091944,
            },

            new Location
            {
                Id = Guid.NewGuid(),
                Name = "Eindhoven",
                Latitude = 51.4416,
                Longitude = 5.4697,
            },

            new Location
            {
                Id = Guid.NewGuid(),
                Name = "Den Bosch",
                Latitude = 51.6864,
                Longitude = 5.3034,
            },

            new Location
            {
                Id = Guid.NewGuid(),
                Name = "Amsterdam",
                Latitude = 52.3702,
                Longitude = 4.8952,
            },

            new Location
            {
                Id = Guid.NewGuid(),
                Name = "Rotterdam",
                Latitude = 51.9244,
                Longitude = 4.4777,
            },

            new Location
            {
                Id = Guid.NewGuid(),
                Name = "Utrecht",
                Latitude = 52.0907,
                Longitude = 5.1221,
            },

            new Location
            {
                Id = Guid.NewGuid(),
                Name = "Groningen",
                Latitude = 53.2194,
                Longitude = 6.5665,
            },

            new Location
            {
                Id = Guid.NewGuid(),
                Name = "Maastricht",
                Latitude = 50.8514,
                Longitude = 5.6902,
            },

            new Location
            {
                Id = Guid.NewGuid(),
                Name = "Haarlem",
                Latitude = 52.379189,
                Longitude = 4.899431,
            },
        };

        var categories = new List<Category>
        {
            new Category{ 
                Id = Guid.NewGuid(), 
                Name = "Vehicles",
                Description="Category about vehicles and stuff",
            },

            new Category
            {
                Id = Guid.NewGuid(), 
                Name = "House",
                Description="Category about houses and stuff",
            },

            new Category
            {
                Id = Guid.NewGuid(), 
                Name = "Electronics",
                Description="Category about electronics and stuff",
            },

            new Category
            {
                Id = Guid.NewGuid(), 
                Name = "Clothes",
                Description="Category about clothes and stuff",
            },

            new Category
            {
                Id = Guid.NewGuid(), 
                Name = "Books",
                Description="Category about books and stuff",
            },
        };

        //modelBuilder.Entity<Location>().HasData(locations);
    }
}