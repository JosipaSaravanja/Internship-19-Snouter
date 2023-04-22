namespace ClassLibrary1.Response.Products;

public class PostProductsResponse
{
    public GetProductResponse Product { get; set; }
    public bool IsCompleted { get; set; }
}