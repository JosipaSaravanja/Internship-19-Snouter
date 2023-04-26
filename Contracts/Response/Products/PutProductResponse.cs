using Contracts.Response.User;

namespace Contracts.Response.Products;

public class PutProductResponse
{
    public GetProductResponse Product { get; set; }
    public bool IsCompleted { get; set; }
}