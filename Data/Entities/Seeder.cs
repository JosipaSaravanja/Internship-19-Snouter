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

        var users = new List<User>
        {
            new User
            {
                Id = Guid.NewGuid(),
                Name="Joe Snow",
                Bio="King in the North",
                Email = "joe.snow@gmail.com",
                Password = "123456789",
                IsAdmin = false,
                LocationId=locations[0].Id,
            },

            new User
            {
                Id = Guid.NewGuid(),
                Name="Arnie Arny",
                Bio="Dev developer",
                Email = "arnie.arny@gmail.com",
                Password = "987654321",
                IsAdmin = false,
                LocationId=locations[0].Id,
            },

            new User
            {
                Id = Guid.NewGuid(),
                Name="Modi Boi",
                Bio="Backend <3",
                Email = "jan.jovis@gmail.com",
                Password = "DrModun-06",
                IsAdmin = false,
                LocationId=locations[1].Id,
            },

            new User
            {
                Id = Guid.NewGuid(),
                Name="Finley Rivas",
                Bio="Guy (I guess) named Finley",
                Email = "finley.rivas@gmail.com",
                Password = "Finley-07",
                IsAdmin = false,
                LocationId=locations[1].Id,
            },

            new User
            {
                Id = Guid.NewGuid(),
                Name="Peter Ferguson",
                Bio="Guy named Peter",
                Email = "peter.ferguson@gmail.com",
                Password = "Peter-08",
                IsAdmin = false,
                LocationId=locations[2].Id,
            },

            new User
            {
                Id = Guid.NewGuid(),
                Name="Jada Shea",
                Bio="Woman named Jada",
                Email = "jada.shea@gmail.com",
                Password = "Jada-93",
                IsAdmin = false,
                LocationId=locations[3].Id,
            },

            new User
            {
                Id = Guid.NewGuid(),
                Name="Rayan Mitchell",
                Bio="Guy named Rayan",
                Email = "rayan.mitchell@gmail.com",
                Password = "Rayan-85",
                IsAdmin = false,
                LocationId=locations[4].Id,
            }
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

        var subCategories = new List<SubCategory>
        {
            new SubCategory
            {
                Id = Guid.NewGuid(),
                Name="Bikes",
                Description="SubCatergy about bikes and stuff",
                CategoryId= categories[0].Id,
                Schema= JSchema.Parse(@"{ 'type': 'object', 'properties': { 'name': {'type':'string'}, 'roles': {'type': 'array'} } }")
            },

            new SubCategory
            {
                Id = Guid.NewGuid(),
                Name="Cars",
                Description="SubCatergy about cars and stuff",
                CategoryId= categories[0].Id,
                Schema= JSchema.Parse(@"{ 'type': 'object', 'properties': { 'name': {'type':'string'}, 'roles': {'type': 'array'} } }")
            },

            new SubCategory
            {
                Id = Guid.NewGuid(),
                Name="Houses",
                Description="SubCatergy about houses and stuff",
                CategoryId= categories[1].Id,
                Schema= JSchema.Parse(@"{ 'type': 'object', 'properties': { 'name': {'type':'string'}, 'roles': {'type': 'array'} } }")
            },

            new SubCategory {
                Id = Guid.NewGuid(),
                Name="Apartments",
                Description="SubCatergy about apartments and stuff",
                CategoryId= categories[1].Id,
                Schema= JSchema.Parse(@"{ 'type': 'object', 'properties': { 'name': {'type':'string'}, 'roles': {'type': 'array'} } }")
            },

            new SubCategory
            {
                Id= Guid.NewGuid(),
                Name="Laptops",
                Description="SubCatergy about laptops and stuff",
                CategoryId= categories[2].Id,
                Schema= JSchema.Parse(@"{ 'type': 'object', 'properties': { 'name': {'type':'string'}, 'roles': {'type': 'array'} } }")
            },

            new SubCategory
            {
                Id = Guid.NewGuid(),
                Name="Pants",
                Description="SubCatergy about pants and stuff",
                CategoryId= categories[3].Id,
                Schema= JSchema.Parse(@"{ 'type': 'object', 'properties': { 'name': {'type':'string'}, 'roles': {'type': 'array'} } }")
            },

            new SubCategory
            {
                Id = Guid.NewGuid(),
                Name="Books",
                Description="SubCatergy about books and stuff",
                CategoryId= categories[4].Id,
                Schema= JSchema.Parse(@"{ 'type': 'object', 'properties': { 'name': {'type':'string'}, 'roles': {'type': 'array'} } }")
            },
        };

    }
}