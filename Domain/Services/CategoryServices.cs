using Contracts.Request.Category;
using Contracts.Response.Category;
using Data;
using Domain.Mappers;
using Domain.Repository;
using Domain.Validation;
using FluentValidation;

namespace Domain.Services;

public class CategoryServices
{
    private readonly CategoryRepository _repo;
    private readonly CategoryMapper _categoryMapper;
    private readonly CategoryValidation _categoryValidation;
    
    public CategoryServices(CategoryRepository context, CategoryMapper categoryMapper, CategoryValidation categoryValidation)
    {
        _repo = context;
        _categoryMapper = categoryMapper;
        _categoryValidation = categoryValidation;
    }
    
    public async Task<GetCategoriesResponse> GetAllCategoriesService() //??
    {
        var categories =  await _repo.GetAllCategories();
        return new  GetCategoriesResponse
        {
            Categories = categories.Select(x => _categoryMapper.CategoryToGetCategoryResponse(x)).ToList()
        };
    }
    public async Task<GetCategoryResponse> GetCategoryByIdService(Guid id, CancellationToken cancellationToken = default)
    {
        var category = await _repo.GetCategoryById(id, cancellationToken);
        return _categoryMapper.CategoryToGetCategoryResponse(category);
    }
    public async Task<PostCategoryResponse> PostCategoryService(PostCategoryRequest postCategoryRequest, CancellationToken cancellationToken = default)
    {
        var category = _categoryMapper.PostCategoryRequestToCategory(postCategoryRequest);
        await _categoryValidation.ValidateAndThrowAsync(category);
        var addition = await _repo.PostCategory(category, cancellationToken);
        if (!addition) return new PostCategoryResponse {IsCompleted = false, Category = null};
        return new PostCategoryResponse
        {
            IsCompleted = true,
            Category = _categoryMapper.CategoryToGetCategoryResponse(category)
        };
    }
    public async Task<PutCategoryResponse> PutCategoryService(PutCategoryRequest putCategoryRequest, CancellationToken cancellationToken = default)
    {
        var category = _categoryMapper.PutCategoryRequestToCategory(putCategoryRequest);
        await _categoryValidation.ValidateAndThrowAsync(category);
        var update = await _repo.PutCategory(category, cancellationToken);
        if (!update) return new PutCategoryResponse {IsCompleted = false, Category = null};
        return new PutCategoryResponse
        {
            IsCompleted = true,
            Category = _categoryMapper.CategoryToGetCategoryResponse(category)
        };
    }
    public async Task<DeleteCategoryResponse> DeleteCategoryService(Guid id, CancellationToken cancellationToken = default)
    {
        var deletion = await _repo.DeleteCategory(id, cancellationToken);
        return new DeleteCategoryResponse {IsCompleted = deletion};
    }


    public async Task<GetCategoriesResponse> GetAllCategories()
    {
        var categories = await _repo.GetAllCategories();
        return new GetCategoriesResponse
        {
            Categories = categories.Select(_categoryMapper.CategoryToGetCategoryResponse).ToList()

        };
    }
}