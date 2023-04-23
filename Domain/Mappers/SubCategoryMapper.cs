using ClassLibrary1.Request.SubCategory;
using ClassLibrary1.Response.SubCategory;
using Data;
using Data.Entities;
using Newtonsoft.Json.Schema;

namespace Domain.Mappers;

public class SubCategoryMapper
{
    private readonly SnouterContext _context;

    public SubCategoryMapper(SnouterContext context)
    {
        _context = context;
    }

    public GetSubCategoryResponse SubCategoryToGetSubCategoryResponse(SubCategory subCategory)
    {
        return new GetSubCategoryResponse
        {
            Id = subCategory.Id,
            Name = subCategory.Name,
            Description = subCategory.Description,
            CategoryId = subCategory.CategoryId,
            Products = _context.Products.Where(x => x.SubCategoryId == subCategory.Id).Select(x => x.Id).ToList(),
            Schema = subCategory.Schema.ToString()
        };
    }

    public SubCategory PostSubCategoryRequestToSubCategory(PostSubCategoryRequest postSubCategoryRequest)
    {
        try
        {
            return new SubCategory
            {
                Id = Guid.NewGuid(),
                Name = postSubCategoryRequest.Name,
                Description = postSubCategoryRequest.Description,
                CategoryId = postSubCategoryRequest.CategoryId,
                Schema = JSchema.Parse(@postSubCategoryRequest.Schema)
            };
        }
        catch
        {
            return null;
        }
    }

    public SubCategory PutSubCategoryRequestToSubCategory(PutSubCategoryRequest putSubCategoryRequest)
    {
        try
        {
            return new SubCategory
            {
                Id = putSubCategoryRequest.Id,
                Name = putSubCategoryRequest.Name,
                Description = putSubCategoryRequest.Description,
                CategoryId = putSubCategoryRequest.CategoryId,
                Schema = JSchema.Parse(@putSubCategoryRequest.Schema)
            };
        }
        catch
        {
            return null;
        }
    }
}