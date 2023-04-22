﻿using ClassLibrary1.Request.Category;
using ClassLibrary1.Request.Products;
using ClassLibrary1.Response.Category;
using ClassLibrary1.Response.Products;
using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Newtonsoft.Json.Linq;

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
            Price = (decimal)product.Price,
            CreatedAt = product.CreatedAt,
            IsSold = product.isSold
        };
    }
    public Product GetProductRequestToProduct(PostProductsRequest postProductsRequest)
    {
        return new Product
        {
            Id = Guid.NewGuid(),
            Name = postProductsRequest.Name,
            Description = postProductsRequest.Description,
            CategoryId = postProductsRequest.CategoryId,
            Data = JObject.Parse(postProductsRequest.Data),
            SubCategoryId = postProductsRequest.SubCategoryId,
            LocationId = postProductsRequest.LocationId,
            BuyerId = postProductsRequest.BuyerId,
            SellerId = postProductsRequest.SellerId,
            ImageUrl = postProductsRequest.Images,
            Price = (double)postProductsRequest.Price,
            CreatedAt = DateTime.Now,
            isSold = false
        };
    }
    
    
}