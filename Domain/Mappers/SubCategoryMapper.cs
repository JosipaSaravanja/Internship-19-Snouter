using ClassLibrary1.Request.SubCategory;
using ClassLibrary1.Response.SubCategory;
using Data;
using Data.Entities;

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
            Products = _context.Products.Where(x => x.SubCategoryId == subCategory.Id).Select(x => x.Id).ToList()
        };
    }
    public SubCategory GetSubCategoryResponseToSubCategory(PostSubCategoryRequest postSubCategoryRequest)
    {
        return new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = postSubCategoryRequest.Name,
            Description = postSubCategoryRequest.Description,
            CategoryId = postSubCategoryRequest.CategoryId
        };
    }
}