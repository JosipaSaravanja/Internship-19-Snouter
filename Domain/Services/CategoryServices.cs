using ClassLibrary1.Request.Category;
using ClassLibrary1.Response.Category;
using Data;
using Domain.Mappers;
using Domain.Repository;

namespace Domain.Services;

public class CategoryServices
{
    private readonly CategoryRepository _repo;
    private readonly CategoryMapper _categoryMapper;
    
    public CategoryServices(CategoryRepository context, CategoryMapper categoryMapper)
    {
        _repo = context;
        _categoryMapper = categoryMapper;
    }
    
    public async Task<GetCategoriesResponse> GetAllCategoriesService()
    {
        var categories =  await _repo.GetAllCategories();
        return new  GetCategoriesResponse
        {
            Categories = categories.Select(x => _categoryMapper.CategoryToGetCategoryResponse(x)).ToList()
        };
    }
    public async Task<GetCategoryResponse> GetCategoryByIdService(Guid id)
    {
        var category = await _repo.GetCategoryById(id);
        return _categoryMapper.CategoryToGetCategoryResponse(category);
    }
    public async Task<PostCategoryResponse> PostCategoryService(PostCategoryRequest postCategoryRequest)
    {
        var category = _categoryMapper.PostCategoryRequestToCategory(postCategoryRequest);
        var addition = await _repo.PostCategory(category);
        if (!addition) return new PostCategoryResponse {IsCompleted = false, Category = null};
        return new PostCategoryResponse
        {
            IsCompleted = true,
            Category = _categoryMapper.CategoryToGetCategoryResponse(category)
        };
    }
    public async Task<PutCategoryResponse> PutCategoryService(PutCategoryRequest putCategoryRequest)
    {
        var category = _categoryMapper.PutCategoryRequestToCategory(putCategoryRequest);
        var update = await _repo.PutCategory(category);
        if (!update) return new PutCategoryResponse {IsCompleted = false, Category = null};
        return new PutCategoryResponse
        {
            IsCompleted = true,
            Category = _categoryMapper.CategoryToGetCategoryResponse(category)
        };
    }
    public async Task<DeleteCategoryResponse> DeleteCategoryService(Guid id)
    {
        var deletion = await _repo.DeleteCategory(id);
        return new DeleteCategoryResponse {IsCompleted = deletion};
    }


}