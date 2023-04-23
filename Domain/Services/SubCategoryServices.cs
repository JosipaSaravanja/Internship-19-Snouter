using ClassLibrary1.Request.Category;
using ClassLibrary1.Request.SubCategory;
using ClassLibrary1.Response.Category;
using ClassLibrary1.Response.SubCategory;
using Domain.Mappers;
using Domain.Repository;

namespace Domain.Services;

public class SubCategoryServices
{
    private readonly SubCategoryRepository _subCategoryRepository;
    private readonly SubCategoryMapper _subCategoryMappers;


    public SubCategoryServices(SubCategoryRepository subCategoryRepository, SubCategoryMapper subCategoryMappers)
    {
        _subCategoryRepository = subCategoryRepository;
        _subCategoryMappers = subCategoryMappers;
    }

    public async Task<GetSubCategoryResponse> GetSubCategoryById(Guid id)
    {
        var subCategory = await _subCategoryRepository.GetSubCategoryById(id);
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
    public async Task<PostSubCategoryResponse> PostSubCategory(PostSubCategoryRequest postSubCategoryRequest)
    {
        var subCategory = _subCategoryMappers.PostSubCategoryRequestToSubCategory(postSubCategoryRequest);
        if (subCategory == null) return new PostSubCategoryResponse {IsCompleted = false, SubCategory = null};
        var addition = await _subCategoryRepository.PostSubCategory(subCategory);
        if (!addition) return new PostSubCategoryResponse {IsCompleted = false, SubCategory = null};
        return new PostSubCategoryResponse()
        {
            IsCompleted = true,
            SubCategory = _subCategoryMappers.SubCategoryToGetSubCategoryResponse(subCategory)
        };
    }
    public async Task<PutSubcategoryResponse> PutSubCategory(PutSubCategoryRequest putSubCategoryRequest)
    {
        var subCategory = _subCategoryMappers.PutSubCategoryRequestToSubCategory(putSubCategoryRequest);
        if (subCategory == null) return new PutSubcategoryResponse {IsCompleted = false, SubCategory = null};
        var update = await _subCategoryRepository.PutSubCategory(subCategory);
        if (!update) return new PutSubcategoryResponse {IsCompleted = false, SubCategory = null};
        return new PutSubcategoryResponse()
        {
            IsCompleted = true,
            SubCategory = _subCategoryMappers.SubCategoryToGetSubCategoryResponse(subCategory)
        };
    }
    public async Task<DeleteSubCategoryResponse> DeleteSubCategory(Guid id)
    {
        var delete = await _subCategoryRepository.DeleteSubCategory(id);
        if (!delete) return new DeleteSubCategoryResponse {IsCompleted = false};
        return new DeleteSubCategoryResponse {IsCompleted = true};
    }
}