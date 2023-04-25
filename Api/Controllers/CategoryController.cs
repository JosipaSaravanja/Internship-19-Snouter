using Contracts.Request.Category;
using Contracts.Response.Category;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly CategoryServices _categoryServices;
    public CategoryController(CategoryServices categoryServices)
    {
        _categoryServices = categoryServices;
    }
    [HttpGet(Routes.Category.GetAll)]
    public async Task<ActionResult<GetCategoriesResponse>> GetAllCategories()
    {
        var response = await _categoryServices.GetAllCategories();
        if (response.Categories == null) return NotFound();
        return Ok(response);
    }
    [HttpGet(Routes.Category.Get)]
    public async Task<ActionResult<GetCategoryResponse>> GetCategoryById([FromRoute] Guid id)
    {
        var response = await _categoryServices.GetCategoryByIdService(id);
        if (response == null) return NotFound();
        return Ok(response);
    }
    [HttpPost(Routes.Category.Post)]
    public async Task<ActionResult<PostCategoryResponse>> PostCategory([FromBody] PostCategoryRequest postCategoryRequest)
    {
        var response = await _categoryServices.PostCategoryService(postCategoryRequest);
        if (response.Category == null) return NotFound();
        return Ok(response);
    }
    [HttpPut(Routes.Category.Put)]
    public async Task<ActionResult<PutCategoryResponse>> PutCategory([FromRoute] Guid id, [FromBody] PostCategoryRequest request)
    {
        var putCategoryRequest = new PutCategoryRequest
        {
            Id = id,
            Name = request.Name,
            Description = request.Description
        };
        var response = await _categoryServices.PutCategoryService(putCategoryRequest);
        if (response.Category == null) return NotFound();
        return Ok(response);
    }
[HttpDelete(Routes.Category.Delete)]
    public async Task<ActionResult<DeleteCategoryResponse>> DeleteCategory(Guid id)
    {
        var response = await _categoryServices.DeleteCategoryService(id);
        if (!response.IsCompleted) return NotFound();
        return Ok(response);
    }


}