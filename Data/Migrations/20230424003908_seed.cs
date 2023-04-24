using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("07551d33-b0bb-4e4c-acc8-1274f199a2f4"), "Category about vehicles and stuff", "Vehicles" },
                    { new Guid("0e632864-0f78-4ce5-b516-3eff8f4d036d"), "Category about electronics and stuff", "Electronics" },
                    { new Guid("7dde2312-c00a-4f26-9e29-8d59cb3143d0"), "Category about houses and stuff", "House" },
                    { new Guid("88fc6385-f9b0-4a54-8599-51dceb0c4b18"), "Category about clothes and stuff", "Clothes" },
                    { new Guid("8a0703f2-bd25-4bf9-b18a-111ba7723be0"), "Category about books and stuff", "Books" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { new Guid("0f8a8dbb-3fa4-4c02-8c5e-50366f22cad6"), 51.586849000000001, 4.7760230000000004, "Breda" },
                    { new Guid("40d0b08d-04c9-4ee5-815c-811addf9bfb8"), 50.851399999999998, 5.6901999999999999, "Maastricht" },
                    { new Guid("5421dffe-d4dc-461b-af7d-849d2e7937ca"), 52.090699999999998, 5.1220999999999997, "Utrecht" },
                    { new Guid("97890040-e91e-43b4-b0be-9f523e93b100"), 51.686399999999999, 5.3033999999999999, "Den Bosch" },
                    { new Guid("bdfa95be-10e6-4b7d-a165-0c79396d89c6"), 52.379188999999997, 4.8994309999999999, "Haarlem" },
                    { new Guid("d140e48a-a065-458d-bfe1-ab3c530d7073"), 51.555, 5.0919439999999998, "Tilburg" },
                    { new Guid("d4bdf9f0-7dc8-43d2-9e62-7ec30e79405a"), 53.2194, 6.5664999999999996, "Groningen" },
                    { new Guid("e162381a-84e9-4487-a82e-95d9b442af99"), 51.441600000000001, 5.4696999999999996, "Eindhoven" },
                    { new Guid("f8bf7e0e-1098-4dea-858f-f1317d4350ba"), 51.924399999999999, 4.4776999999999996, "Rotterdam" },
                    { new Guid("fc6011a1-1f33-4b57-8ec9-f1b1560336b3"), 52.370199999999997, 4.8952, "Amsterdam" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Schema" },
                values: new object[,]
                {
                    { new Guid("29c41fd6-2d98-44f7-9101-39c275594212"), new Guid("07551d33-b0bb-4e4c-acc8-1274f199a2f4"), "SubCatergy about cars and stuff", "Cars", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"roles\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("64258f97-7b89-4838-9a95-1b18d794bbac"), new Guid("7dde2312-c00a-4f26-9e29-8d59cb3143d0"), "SubCatergy about houses and stuff", "Houses", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"roles\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("6b3744c9-7e4e-42d2-b554-71227ac764a6"), new Guid("8a0703f2-bd25-4bf9-b18a-111ba7723be0"), "SubCatergy about books and stuff", "Books", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"roles\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("804a6233-0336-4d31-8ac3-f71548e24372"), new Guid("88fc6385-f9b0-4a54-8599-51dceb0c4b18"), "SubCatergy about pants and stuff", "Pants", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"roles\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("95f03370-7eef-403a-a0be-1af533f602a4"), new Guid("7dde2312-c00a-4f26-9e29-8d59cb3143d0"), "SubCatergy about apartments and stuff", "Apartments", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"roles\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("e7300164-5416-4cad-8375-70a49c760f6d"), new Guid("07551d33-b0bb-4e4c-acc8-1274f199a2f4"), "SubCatergy about bikes and stuff", "Bikes", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"roles\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("ff341249-6486-4747-bdd7-54014cf0c2eb"), new Guid("0e632864-0f78-4ce5-b516-3eff8f4d036d"), "SubCatergy about laptops and stuff", "Laptops", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"roles\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "Email", "IsAdmin", "LocationId", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("0b1eeb79-e2d0-4b8b-839a-5107bd2371e8"), "King in the North", "joe.snow@gmail.com", false, new Guid("0f8a8dbb-3fa4-4c02-8c5e-50366f22cad6"), "Joe Snow", "123456789" },
                    { new Guid("3c56d82e-d630-45ef-9f5c-9fddd6ffb03a"), "Dev developer", "arnie.arny@gmail.com", false, new Guid("0f8a8dbb-3fa4-4c02-8c5e-50366f22cad6"), "Arnie Arny", "987654321" },
                    { new Guid("657fa6df-5a3d-42d0-959d-fb1acca316be"), "Backend <3", "jan.jovis@gmail.com", false, new Guid("d140e48a-a065-458d-bfe1-ab3c530d7073"), "Modi Boi", "DrModun-06" },
                    { new Guid("b74543f8-c311-4543-8cee-54b0a99e5f43"), "Guy named Rayan", "rayan.mitchell@gmail.com", false, new Guid("fc6011a1-1f33-4b57-8ec9-f1b1560336b3"), "Rayan Mitchell", "Rayan-85" },
                    { new Guid("c65df554-825d-4ff6-b5cd-77a5935ca910"), "Guy (I guess) named Finley", "finley.rivas@gmail.com", false, new Guid("d140e48a-a065-458d-bfe1-ab3c530d7073"), "Finley Rivas", "Finley-07" },
                    { new Guid("f0042957-d1ff-4417-a19c-f9c832fd654e"), "Woman named Jada", "jada.shea@gmail.com", false, new Guid("97890040-e91e-43b4-b0be-9f523e93b100"), "Jada Shea", "Jada-93" },
                    { new Guid("f45a9d27-d4b3-4829-be27-8e65a1636821"), "Guy named Peter", "peter.ferguson@gmail.com", false, new Guid("e162381a-84e9-4487-a82e-95d9b442af99"), "Peter Ferguson", "Peter-08" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BuyerId", "CategoryId", "CreatedAt", "Data", "Description", "ImageUrl", "LocationId", "Name", "Price", "SellerId", "SubCategoryId", "isSold" },
                values: new object[,]
                {
                    { new Guid("0f70028a-7423-47fa-a70f-2ea96ded9bae"), new Guid("f0042957-d1ff-4417-a19c-f9c832fd654e"), new Guid("7dde2312-c00a-4f26-9e29-8d59cb3143d0"), new DateTime(2023, 4, 24, 0, 39, 8, 765, DateTimeKind.Utc).AddTicks(1790), "{\r\n  \"name\": \"string\",\r\n  \"roles\": [\r\n    \"string\",\r\n    \"string\"\r\n  ]\r\n}", "Cool car black color", new List<string> { "https://hips.hearstapps.com/hmg-prod/images/pile-of-tires-on-white-background-royalty-free-image-672151801-1561751929.jpg?resize=2048:*    ", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS9-MO724XZahMAnTCwgdi0vc6rrPe9mlv1odARV9W0DA&s" }, new Guid("5421dffe-d4dc-461b-af7d-849d2e7937ca"), "Tires", 10000.0, new Guid("f0042957-d1ff-4417-a19c-f9c832fd654e"), new Guid("64258f97-7b89-4838-9a95-1b18d794bbac"), false },
                    { new Guid("38319901-c804-4ad6-b794-1ba2a2d9ad04"), new Guid("f0042957-d1ff-4417-a19c-f9c832fd654e"), new Guid("8a0703f2-bd25-4bf9-b18a-111ba7723be0"), new DateTime(2023, 4, 24, 0, 39, 8, 765, DateTimeKind.Utc).AddTicks(1636), "{\r\n  \"name\": \"string\",\r\n  \"roles\": [\r\n    \"string\",\r\n    \"string\"\r\n  ]\r\n}", "Made out of cotton.", new List<string> { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Trousers-colourisolated.jpg/1200px-Trousers-colourisolated.jpg", "https://www.fabricsight.com/blogs/posts/fabrics-for-trousers-top-10-fabrics-for-your-trousers-complete-guide" }, new Guid("97890040-e91e-43b4-b0be-9f523e93b100"), "Trousers", 150.0, new Guid("f0042957-d1ff-4417-a19c-f9c832fd654e"), new Guid("6b3744c9-7e4e-42d2-b554-71227ac764a6"), false },
                    { new Guid("537f73ff-402d-4cf7-a5b1-a83ab33c3439"), new Guid("b74543f8-c311-4543-8cee-54b0a99e5f43"), new Guid("07551d33-b0bb-4e4c-acc8-1274f199a2f4"), new DateTime(2023, 4, 24, 0, 39, 8, 765, DateTimeKind.Utc).AddTicks(1750), "{\r\n  \"name\": \"string\",\r\n  \"roles\": [\r\n    \"string\",\r\n    \"string\"\r\n  ]\r\n}", "Cool car black color", new List<string> { "https://hips.hearstapps.com/hmg-prod/images/pile-of-tires-on-white-background-royalty-free-image-672151801-1561751929.jpg?resize=2048:*    ", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS9-MO724XZahMAnTCwgdi0vc6rrPe9mlv1odARV9W0DA&s" }, new Guid("d140e48a-a065-458d-bfe1-ab3c530d7073"), "Tires", 10000.0, new Guid("b74543f8-c311-4543-8cee-54b0a99e5f43"), new Guid("29c41fd6-2d98-44f7-9101-39c275594212"), false },
                    { new Guid("7566a634-0185-49b4-b491-cc4328903524"), new Guid("f45a9d27-d4b3-4829-be27-8e65a1636821"), new Guid("8a0703f2-bd25-4bf9-b18a-111ba7723be0"), new DateTime(2023, 4, 24, 0, 39, 8, 765, DateTimeKind.Utc).AddTicks(1544), "{\r\n  \"name\": \"string\",\r\n  \"roles\": [\r\n    \"string\",\r\n    \"string\"\r\n  ]\r\n}", "Second book in Harry Potter book serial", new List<string> { "https://shop.skolskaknjiga.hr/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/1/7/173972.jpg", "https://m.media-amazon.com/images/I/91OINeHnJGL._AC_UF1000,1000_QL80_.jpg" }, new Guid("97890040-e91e-43b4-b0be-9f523e93b100"), "Harry Potter and the chamber of secrets", 200.0, new Guid("f45a9d27-d4b3-4829-be27-8e65a1636821"), new Guid("6b3744c9-7e4e-42d2-b554-71227ac764a6"), false },
                    { new Guid("805debd3-6a09-4fcc-ac95-b3cecbbd5828"), new Guid("3c56d82e-d630-45ef-9f5c-9fddd6ffb03a"), new Guid("8a0703f2-bd25-4bf9-b18a-111ba7723be0"), new DateTime(2023, 4, 24, 0, 39, 8, 765, DateTimeKind.Utc).AddTicks(1411), "{\r\n  \"name\": \"string\",\r\n  \"roles\": [\r\n    \"string\",\r\n    \"string\"\r\n  ]\r\n}", "First book in Harry Potter book serial", new List<string> { "https://cdn.ozone.hr/media/catalog/product/cache/1/image/400x498/a4e40ebdc3e371adff845072e1c73f37/h/a/a19438e622aa321a0e73f360f1f3f855/harry-potter-and-the-philosopher-s-stone-30.jpg", "https://upload.wikimedia.org/wikipedia/en/6/6b/Harry_Potter_and_the_Philosopher%27s_Stone_Book_Cover.jpg" }, new Guid("97890040-e91e-43b4-b0be-9f523e93b100"), "Harry Potter and the philosopher's stone", 100.0, new Guid("3c56d82e-d630-45ef-9f5c-9fddd6ffb03a"), new Guid("6b3744c9-7e4e-42d2-b554-71227ac764a6"), false },
                    { new Guid("c6f5e625-7739-4339-a659-16e3f8b9b12c"), new Guid("c65df554-825d-4ff6-b5cd-77a5935ca910"), new Guid("07551d33-b0bb-4e4c-acc8-1274f199a2f4"), new DateTime(2023, 4, 24, 0, 39, 8, 765, DateTimeKind.Utc).AddTicks(1675), "{\r\n  \"name\": \"string\",\r\n  \"roles\": [\r\n    \"string\",\r\n    \"string\"\r\n  ]\r\n}", "Cool mountain bike black color", new List<string> { "https://s3.us-east-1.amazonaws.com/craft-marinbikes/images/2020/bikes/category/header/_1200x630_fit_center-center_82_none/23-rzxr-action-65.jpg?mtime=1668448653", "https://images.immediate.co.uk/production/volatile/sites/21/2020/06/Santa-Cruz-5010-CC-X01-RSV-25-1ddbe5a.jpg?quality=90&resize=768,574" }, new Guid("d140e48a-a065-458d-bfe1-ab3c530d7073"), "Bike", 1000.0, new Guid("c65df554-825d-4ff6-b5cd-77a5935ca910"), new Guid("e7300164-5416-4cad-8375-70a49c760f6d"), false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("40d0b08d-04c9-4ee5-815c-811addf9bfb8"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("bdfa95be-10e6-4b7d-a165-0c79396d89c6"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d4bdf9f0-7dc8-43d2-9e62-7ec30e79405a"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("f8bf7e0e-1098-4dea-858f-f1317d4350ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f70028a-7423-47fa-a70f-2ea96ded9bae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38319901-c804-4ad6-b794-1ba2a2d9ad04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("537f73ff-402d-4cf7-a5b1-a83ab33c3439"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7566a634-0185-49b4-b491-cc4328903524"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("805debd3-6a09-4fcc-ac95-b3cecbbd5828"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6f5e625-7739-4339-a659-16e3f8b9b12c"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("804a6233-0336-4d31-8ac3-f71548e24372"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("95f03370-7eef-403a-a0be-1af533f602a4"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ff341249-6486-4747-bdd7-54014cf0c2eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b1eeb79-e2d0-4b8b-839a-5107bd2371e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("657fa6df-5a3d-42d0-959d-fb1acca316be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e632864-0f78-4ce5-b516-3eff8f4d036d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88fc6385-f9b0-4a54-8599-51dceb0c4b18"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("5421dffe-d4dc-461b-af7d-849d2e7937ca"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("29c41fd6-2d98-44f7-9101-39c275594212"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("64258f97-7b89-4838-9a95-1b18d794bbac"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6b3744c9-7e4e-42d2-b554-71227ac764a6"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e7300164-5416-4cad-8375-70a49c760f6d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c56d82e-d630-45ef-9f5c-9fddd6ffb03a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b74543f8-c311-4543-8cee-54b0a99e5f43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c65df554-825d-4ff6-b5cd-77a5935ca910"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0042957-d1ff-4417-a19c-f9c832fd654e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f45a9d27-d4b3-4829-be27-8e65a1636821"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("07551d33-b0bb-4e4c-acc8-1274f199a2f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7dde2312-c00a-4f26-9e29-8d59cb3143d0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a0703f2-bd25-4bf9-b18a-111ba7723be0"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("0f8a8dbb-3fa4-4c02-8c5e-50366f22cad6"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("97890040-e91e-43b4-b0be-9f523e93b100"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d140e48a-a065-458d-bfe1-ab3c530d7073"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e162381a-84e9-4487-a82e-95d9b442af99"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("fc6011a1-1f33-4b57-8ec9-f1b1560336b3"));
        }
    }
}
