using ClassLibrary1.Request.SubCategory;
using ClassLibrary1.Response.SubCategory;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;
[ApiController]
public class SubCategroyController : ControllerBase
{
    private readonly SubCategoryServices _subCategoryServices;
    public SubCategroyController(SubCategoryServices subCategoryServices)
    {
        _subCategoryServices = subCategoryServices;
    }
    [HttpGet(Routes.SubCategory.GetAll)]
    public async Task<ActionResult<GetSubCategoryResponse>> GetAllSubCategories()
    {
        var response = await _subCategoryServices.GetAllSubCategories();
        if (response.SubCategories == null) return NotFound();
        return Ok(response);
    }
    [HttpGet(Routes.SubCategory.Get)]
    public async Task<ActionResult<GetSubCategoryResponse>> GetSubCategoryById([FromRoute] Guid id)
    {
        var response = await _subCategoryServices.GetSubCategoryById(id);
        if (response == null) return NotFound();
        return Ok(response);
    }
    [HttpPost(Routes.SubCategory.Post)]
    public async Task<ActionResult<PostSubCategoryResponse>> PostSubCategory([FromBody] PostSubCategoryRequest postSubCategoryRequest)
    {
        var response = await _subCategoryServices.PostSubCategory(postSubCategoryRequest);
        if (response.SubCategory == null) return NotFound();
        return Ok(response);
    }
    [HttpPut(Routes.SubCategory.Put)]
    public async Task<ActionResult<PutSubcategoryResponse>> PutSubCategory([FromRoute] Guid id, [FromBody] PostSubCategoryRequest request)
    {
        var putSubCategoryRequest = new PutSubCategoryRequest
        {
            Id = id,
            Name = request.Name,
            CategoryId = request.CategoryId
        };
        var response = await _subCategoryServices.PutSubCategory(putSubCategoryRequest);
        if (response.SubCategory == null) return NotFound();
        return Ok(response);
    }
    [HttpDelete(Routes.SubCategory.Delete)]
    public async Task<ActionResult<DeleteSubCategoryResponse>> DeleteSubCategory(Guid id)
    {
        var response = await _subCategoryServices.DeleteSubCategory(id);
        if (!response.IsCompleted) return NotFound();
        return Ok(response);
    }

}
