using Contracts.Request.Category;
using Contracts.Response.Category;
using Data;
using Data.Entities;

namespace Domain.Mappers;

public class CategoryMapper
{
    private readonly SnouterContext _context;

    public CategoryMapper(SnouterContext context)
    {
        _context = context;
    }

    public GetCategoryResponse CategoryToGetCategoryResponse(Category category)
    {
        return new GetCategoryResponse
        {
            Id = category.Id,
            Name = category.Name,
            Description = category.Description,
            SubCategories = _context.SubCategories.Where(x => x.CategoryId == category.Id).Select(x => x.Id).ToList(),
            Products = _context.Products.Where(x => x.CategoryId == category.Id).Select(x => x.Id).ToList()
        };
    }

    public Category PostCategoryRequestToCategory(PostCategoryRequest postCategoryRequest)
    {
        return new Category
        {
            Id = Guid.NewGuid(),
            Name = postCategoryRequest.Name,
            Description = postCategoryRequest.Description
        };
    }

    public Category PutCategoryRequestToCategory(PutCategoryRequest putCategoryRequest)
    {
        return new Category
        {
            Id = putCategoryRequest.Id,
            Name = putCategoryRequest.Name,
            Description = putCategoryRequest.Description
        };
    }
}
