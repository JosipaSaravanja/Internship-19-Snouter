namespace Api;

public class Routes
{
    private const string Base = "api";
    public static class Category
    {
        public const string GetAll = Base + $"/categories";
        public const string Get = Base + $"/categories/{{id:Guid}}";
        public const string Post = Base + $"/categories";
        public const string Put = Base + $"/categories/{{id:Guid}}";
        public const string Delete = Base + $"/categories/{{id:Guid}}";
    }
    public static class Location
    {
        public const string GetAll = Base + $"/locations";
        public const string Get = Base + $"/locations/{{id:Guid}}";
        public const string Post = Base + $"/locations";
        public const string Put = Base + $"/locations/{{id:Guid}}";
        public const string Delete = Base + $"/locations/{{id:Guid}}";
    }
    public static class Products
    {
        public const string GetAll = Base + $"/products";
        public const string Get = Base + $"/products/{{id:Guid}}";
        public const string Post = Base + $"/products";
        public const string Put = Base + $"/products/{{id:Guid}}";
        public const string Delete = Base + $"/products/{{id:Guid}}";
        public const string Buy = Base + $"/products/{{id:Guid}}/buy";
    }
    public static class User
    {
        public const string GetAll = Base + $"/users";
        public const string Get = Base + $"/users/{{id:Guid}}";
        public const string Post = Base + $"/users";
        public const string Put = Base + $"/users/{{id:Guid}}";
        public const string Delete = Base + $"/users/{{id:Guid}}";
    }
    public static class SubCategory
    {
        public const string GetAll = Base + $"/subcategories";
        public const string Get = Base + $"/subcategories/{{id:Guid}}";
        public const string Post = Base + $"/subcategories";
        public const string Put = Base + $"/subcategories/{{id:Guid}}";
        public const string Delete = Base + $"/subcategories/{{id:Guid}}";
    }
}