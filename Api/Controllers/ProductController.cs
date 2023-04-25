using Contracts.Request.Products;
using Contracts.Response.Products;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
public class ProductsController : ControllerBase
{
   private readonly ProductsServices _productsServices;
   public ProductsController(ProductsServices productsServices)
   {
       _productsServices = productsServices;
   }
    [HttpGet(Routes.Products.GetAll)]
    public async Task<ActionResult<GetProductsResponse>> GetAllProducts()
    {
        var response = await _productsServices.GetAllProducts();
        if (response.Products == null) return NotFound();
        return Ok(response);
    }
    [HttpGet(Routes.Products.Get)]
    public async Task<ActionResult<GetProductResponse>> GetProductById([FromRoute] Guid id)
    {
        var response = await _productsServices.GetProductById(id);
        if (response == null) return NotFound();
        return Ok(response);
    }
    [HttpPost(Routes.Products.Post)]
    public async Task<ActionResult<PostProductsResponse>> PostProduct([FromBody] PostProductsRequest postProductRequest)
    {
        var response = await _productsServices.PostProduct(postProductRequest);
        if (response.Product == null) return NotFound();
        return Ok(response);
    }
    [HttpPut(Routes.Products.Put)]
    public async Task<ActionResult<PutProductResponse>> PutProduct([FromRoute] Guid id, [FromBody] PostProductsRequest request)
    {
        var putProductRequest = new PutProductsRequest
        {
            Id = id,
            Name = request.Name,
            Price = request.Price,
            Description = request.Description,
            CategoryId = request.CategoryId,
            Images = request.Images,
            SubCategoryId = request.SubCategoryId,
            SellerId = request.SellerId,
            LocationId = request.LocationId,
            Data = request.Data

        };
        var response = await _productsServices.PutProduct(putProductRequest);
        if (response.Product == null) return NotFound();
        return Ok(response);
    }
    [HttpDelete(Routes.Products.Delete)]
    public async Task<ActionResult<DeleteProductResponse>> DeleteProduct(Guid id)
    {
        var response = await _productsServices.DeleteProduct(id);
        if (!response.IsCompleted) return NotFound();
        return Ok(response);
    }
    [HttpPut(Routes.Products.Buy)]
    public async Task<ActionResult<BuyProductResponse>> BuyProduct([FromRoute] Guid id, [FromBody] Guid buyerId){
    var request = new BuyProductRequest
        {
            Id = id,
            BuyerId = buyerId
        };
     var response = await _productsServices.BuyProduct(request);
        if (!response.IsCompleted) return NotFound();
        return Ok(response);
    }

}