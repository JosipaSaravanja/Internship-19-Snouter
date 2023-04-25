using Contracts.Response.SubCategory;
using Contracts.Request.Category;
using Contracts.Request.SubCategory;
using Contracts.Response.Category;
using Contracts.Response.SubCategory;
using Domain.Mappers;
using Domain.Repository;
using Domain.Validation;
using FluentValidation;

namespace Domain.Services;

public class SubCategoryServices
{
    private readonly SubCategoryRepository _subCategoryRepository;
    private readonly SubCategoryMapper _subCategoryMappers;
    private readonly SubCategoryValidation _subCategoryValidation;


    public SubCategoryServices(SubCategoryRepository subCategoryRepository, SubCategoryMapper subCategoryMappers, SubCategoryValidation subCategoryValidation)
    {
        _subCategoryRepository = subCategoryRepository;
        _subCategoryMappers = subCategoryMappers;
        _subCategoryValidation = subCategoryValidation;
    }

    public async Task<GetSubCategoryResponse> GetSubCategoryById(Guid id, CancellationToken cancellationToken = default)
    {
        var subCategory = await _subCategoryRepository.GetSubCategoryById(id, cancellationToken);
        return _subCategoryMappers.SubCategoryToGetSubCategoryResponse(subCategory);
    }

    public async Task<GetSubCategoriesResponse> GetAllSubCategories()
    {
        var subCategories = await _subCategoryRepository.GetAllSubCategories();
        return new GetSubCategoriesResponse
        {
            SubCategories = subCategories.Select(x => _subCategoryMappers.SubCategoryToGetSubCategoryResponse(x))
                .ToList()
        };
    }
    public async Task<PostSubCategoryResponse> PostSubCategory(PostSubCategoryRequest postSubCategoryRequest, CancellationToken cancellationToken = default)
    {
        var subCategory = _subCategoryMappers.PostSubCategoryRequestToSubCategory(postSubCategoryRequest);
        await _subCategoryValidation.ValidateAndThrowAsync(subCategory);
        if (subCategory == null) return new PostSubCategoryResponse {IsCompleted = false, SubCategory = null};
        var addition = await _subCategoryRepository.PostSubCategory(subCategory, cancellationToken);
        if (!addition) return new PostSubCategoryResponse {IsCompleted = false, SubCategory = null};
        return new PostSubCategoryResponse()
        {
            IsCompleted = true,
            SubCategory = _subCategoryMappers.SubCategoryToGetSubCategoryResponse(subCategory)
        };
    }
    public async Task<PutSubcategoryResponse> PutSubCategory(PutSubCategoryRequest putSubCategoryRequest, CancellationToken cancellationToken = default)
    {
        var subCategory = _subCategoryMappers.PutSubCategoryRequestToSubCategory(putSubCategoryRequest);
        await _subCategoryValidation.ValidateAndThrowAsync(subCategory);
        if (subCategory == null) return new PutSubcategoryResponse {IsCompleted = false, SubCategory = null};
        var update = await _subCategoryRepository.PutSubCategory(subCategory, cancellationToken);
        if (!update) return new PutSubcategoryResponse {IsCompleted = false, SubCategory = null};
        return new PutSubcategoryResponse()
        {
            IsCompleted = true,
            SubCategory = _subCategoryMappers.SubCategoryToGetSubCategoryResponse(subCategory)
        };
    }
    public async Task<DeleteSubCategoryResponse> DeleteSubCategory(Guid id, CancellationToken cancellationToken = default)
    {
        var delete = await _subCategoryRepository.DeleteSubCategory(id, cancellationToken);
        if (!delete) return new DeleteSubCategoryResponse {IsCompleted = false};
        return new DeleteSubCategoryResponse {IsCompleted = true};
    }
}