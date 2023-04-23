using Data.Entities;
using Microsoft.EntityFrameworkCore;

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
                Name = "Zagreb",
                Latitude = 45.81769,
                Longitude = 15.96449,
            },
            new Location
            {
                Id = Guid.NewGuid(),
                Name = "Split",
                Latitude = 43.51525,
                Longitude = 16.44860,
            },
            new Location
            {
                Id = Guid.NewGuid(),
                Name = "Šibenik",
                Latitude = 43.73135,
                Longitude = 15.88985,
            },
            new Location
            {
                Id = Guid.NewGuid(),
                Name = "Zadar",
                Latitude = 44.12015,
                Longitude = 15.24162,
            },
            new Location
            {
                Id = Guid.NewGuid(),
                Name = "Dubrovnik",
                Latitude = 42.65093,
                Longitude = 18.095883,
            },
            new Location
            {
                Id = Guid.NewGuid(),
                Name = "Rijeka",
                Latitude = 45.32811,
                Longitude = 14.46889,
            },
            new Location
            {
                Id = Guid.NewGuid(),
                Name = "Almere",
                Latitude = 52.370216,
                Longitude = 5.214424,
            },
            new Location
            {
                Id = Guid.NewGuid(),
                Name = "Breda",
                Latitude = 51.586849,
                Longitude = 4.776023,
            },
        };

        var categories = new List<Category>
        {
            new Category{ 
                Id = Guid.NewGuid(), 
                Name="",
                Description="",
            },
        };

        var subCategories = new List<SubCategory>
        {
            new SubCategory
            {
                Id= Guid.NewGuid(),

            },
        };


        modelBuilder.Entity<Location>().HasData(locations);
    }
}