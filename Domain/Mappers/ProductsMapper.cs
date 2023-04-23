using ClassLibrary1.Request.Category;
using ClassLibrary1.Request.Products;
using ClassLibrary1.Response.Category;
using ClassLibrary1.Response.Products;
using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace Domain.Mappers;
public class ProductsMapper
{
    private readonly SnouterContext _context;
    public ProductsMapper(SnouterContext context)
    {
        _context = context;
    }
    public GetProductResponse ProductToGetProductResponse(Product product)
    {
        return new GetProductResponse
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            CategoryId = product.CategoryId,
            Data = product.Data.ToString(),
            SubCategoryId = product.SubCategoryId,
            LocationId = product.LocationId,
            BuyerId = product.BuyerId,
            SellerId = product.SellerId,
            Images = product.ImageUrl,
            Price = (double)product.Price,
            CreatedAt = product.CreatedAt,
            IsSold = product.isSold
        };
    }
    public Product PostProductRequestToProduct(PostProductsRequest postProductsRequest)
    {
        try
        {
            return new Product
            {
                Id = Guid.NewGuid(),
                Name = postProductsRequest.Name,
                Description = postProductsRequest.Description,
                CategoryId = postProductsRequest.CategoryId,
                Data = JObject.Parse(@postProductsRequest.Data),
                SubCategoryId = postProductsRequest.SubCategoryId,
                LocationId = postProductsRequest.LocationId,
                SellerId = postProductsRequest.SellerId,
                ImageUrl = postProductsRequest.Images,
                Price = (double)postProductsRequest.Price,
                CreatedAt = DateTime.UtcNow,
                BuyerId = postProductsRequest.SellerId, //because the product is not sold yet
                isSold = false
            };
        }
        catch
        {
            return null;
        }
    }
    public Product PutProductRequestToProduct(PutProductsRequest putProductsRequest)
    {
        try
        {
            var product = new Product
            {
                Id = putProductsRequest.Id,
                Name = putProductsRequest.Name,
                BuyerId = putProductsRequest.SellerId,      //because the product is not sold yet
                Description = putProductsRequest.Description,
                CategoryId = putProductsRequest.CategoryId,
                Data = JObject.Parse(@putProductsRequest.Data),
                SubCategoryId = putProductsRequest.SubCategoryId,
                LocationId = putProductsRequest.LocationId,
                SellerId = putProductsRequest.SellerId,
                ImageUrl = putProductsRequest.Images,
                Price = (double)putProductsRequest.Price,
                CreatedAt = DateTime.UtcNow,
                isSold = false
            };
            if (product.Data.IsValid(_context.SubCategories.Find(product.SubCategoryId).Schema))
            {
                return product;
            }
            else
            {
                return null;
            }
        }
        catch
        {
            return null;
        }
    }
    
    
}