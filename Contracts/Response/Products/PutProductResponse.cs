using ClassLibrary1.Response.User;

namespace ClassLibrary1.Response.Products;

public class PutProductResponse
{
    public GetProductResponse Product { get; set; }
    public bool IsCompleted { get; set; }
}