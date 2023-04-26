namespace Contracts.Request.Products;

public class BuyProductRequest
{
    public Guid Id { get; set; }
    public Guid BuyerId { get; set; }
}