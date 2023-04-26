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
                LocationId=locations[0].Id,
            },

            new User
            {
                Id = Guid.NewGuid(),
                Name="Arnie Arny",
                Bio="Dev developer",
                Email = "arnie.arny@gmail.com",
                Password = "987654321",
                LocationId=locations[0].Id,
            },

            new User
            {
                Id = Guid.NewGuid(),
                Name="Modi Boi",
                Bio="Backend <3",
                Email = "jan.jovis@gmail.com",
                Password = "DrModun-06",
                LocationId=locations[1].Id,
            },

            new User
            {
                Id = Guid.NewGuid(),
                Name="Finley Rivas",
                Bio="Guy (I guess) named Finley",
                Email = "finley.rivas@gmail.com",
                Password = "Finley-07",
                LocationId=locations[1].Id,
            },

            new User
            {
                Id = Guid.NewGuid(),
                Name="Peter Ferguson",
                Bio="Guy named Peter",
                Email = "peter.ferguson@gmail.com",
                Password = "Peter-08",
                LocationId=locations[2].Id,
            },

            new User
            {
                Id = Guid.NewGuid(),
                Name="Jada Shea",
                Bio="Woman named Jada",
                Email = "jada.shea@gmail.com",
                Password = "Jada-93",
                LocationId=locations[3].Id,
            },

            new User
            {
                Id = Guid.NewGuid(),
                Name="Rayan Mitchell",
                Bio="Guy named Rayan",
                Email = "rayan.mitchell@gmail.com",
                Password = "Rayan-85",
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

        var products = new List<Product>
        {
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Harry Potter and the philosopher's stone",
                Description = "First book in Harry Potter book serial",
                Price = 100,
                ImageUrl = new List<string>{
                    "https://cdn.ozone.hr/media/catalog/product/cache/1/image/400x498/a4e40ebdc3e371adff845072e1c73f37/h/a/a19438e622aa321a0e73f360f1f3f855/harry-potter-and-the-philosopher-s-stone-30.jpg",
                    "https://upload.wikimedia.org/wikipedia/en/6/6b/Harry_Potter_and_the_Philosopher%27s_Stone_Book_Cover.jpg"
                },
                CategoryId = categories[4].Id,
                SubCategoryId = subCategories[6].Id,
                LocationId = locations[3].Id,
                BuyerId= users[1].Id,
                SellerId= users[1].Id,
                CreatedAt= DateTime.UtcNow,
                Data = JObject.Parse(@"{ 'name': 'string', 'roles': ['string', 'string'] }"),
                isSold = false,
            },

            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Harry Potter and the chamber of secrets",
                Description = "Second book in Harry Potter book serial",
                Price = 200,
                ImageUrl = new List<string>
                {
                    "https://shop.skolskaknjiga.hr/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/1/7/173972.jpg",
                    "https://m.media-amazon.com/images/I/91OINeHnJGL._AC_UF1000,1000_QL80_.jpg"
                },
                CategoryId = categories[4].Id,
                SubCategoryId = subCategories[6].Id,
                LocationId = locations[3].Id,
                BuyerId= users[4].Id,
                SellerId= users[4].Id,
                CreatedAt= DateTime.UtcNow,
                Data = JObject.Parse(@"{ 'name': 'string', 'roles': ['string', 'string'] }"),
                isSold = false,
            },

            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Trousers",
                Description = "Made out of cotton.",
                Price = 150,
                ImageUrl = new List<string>
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Trousers-colourisolated.jpg/1200px-Trousers-colourisolated.jpg",
                    "https://www.fabricsight.com/blogs/posts/fabrics-for-trousers-top-10-fabrics-for-your-trousers-complete-guide"
                },
                CategoryId = categories[4].Id,
                SubCategoryId = subCategories[6].Id,
                LocationId = locations[3].Id,
                BuyerId= users[5].Id,
                SellerId= users[5].Id,
                CreatedAt= DateTime.UtcNow,
                Data = JObject.Parse(@"{ 'name': 'string', 'roles': ['string', 'string'] }"),
                isSold = false,
            },

            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Bike",
                Description = "Cool mountain bike black color",
                Price = 1000,
                ImageUrl = new List<string>
                {
                    "https://s3.us-east-1.amazonaws.com/craft-marinbikes/images/2020/bikes/category/header/_1200x630_fit_center-center_82_none/23-rzxr-action-65.jpg?mtime=1668448653",
                    "https://images.immediate.co.uk/production/volatile/sites/21/2020/06/Santa-Cruz-5010-CC-X01-RSV-25-1ddbe5a.jpg?quality=90&resize=768,574"
                },
                CategoryId = categories[0].Id,
                SubCategoryId = subCategories[0].Id,
                LocationId = locations[1].Id,
                BuyerId= users[3].Id,
                SellerId= users[3].Id,
                CreatedAt= DateTime.UtcNow,
                Data = JObject.Parse(@"{ 'name': 'string', 'roles': ['string', 'string'] }"),
                isSold = false,
            },

            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Tires",
                Description = "Cool car black color",
                Price = 10000,
                ImageUrl = new List<string>
                {
                    "https://hips.hearstapps.com/hmg-prod/images/pile-of-tires-on-white-background-royalty-free-image-672151801-1561751929.jpg?resize=2048:*    ",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS9-MO724XZahMAnTCwgdi0vc6rrPe9mlv1odARV9W0DA&s"
                },
                CategoryId = categories[0].Id,
                SubCategoryId = subCategories[1].Id,
                LocationId = locations[1].Id,
                BuyerId= users[6].Id,
                SellerId= users[6].Id,
                CreatedAt= DateTime.UtcNow,
                Data = JObject.Parse(@"{ 'name': 'string', 'roles': ['string', 'string'] }"),
                isSold = false,
            },

            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Tires",
                Description = "Cool car black color",
                Price = 10000,
                ImageUrl = new List<string>
                {
                    "https://hips.hearstapps.com/hmg-prod/images/pile-of-tires-on-white-background-royalty-free-image-672151801-1561751929.jpg?resize=2048:*    ",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS9-MO724XZahMAnTCwgdi0vc6rrPe9mlv1odARV9W0DA&s"
                },
                CategoryId = categories[1].Id,
                SubCategoryId = subCategories[2].Id,
                LocationId = locations[6].Id,
                BuyerId= users[5].Id,
                SellerId= users[5].Id,
                CreatedAt= DateTime.UtcNow,
                Data = JObject.Parse(@"{ 'name': 'string', 'roles': ['string', 'string'] }"),
                isSold = false,
            }
        };

        modelBuilder.Entity<Location>().HasData(locations);
        modelBuilder.Entity<Category>().HasData(categories);
        modelBuilder.Entity<SubCategory>().HasData(subCategories);
        modelBuilder.Entity<Product>().HasData(products);
        modelBuilder.Entity<User>().HasData(users);
    }
}