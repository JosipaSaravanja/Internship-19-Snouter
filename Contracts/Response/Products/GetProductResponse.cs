namespace ClassLibrary1.Response.Products;

public class GetProductResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public Guid LocationId { get; set; }
    public Guid CategoryId { get; set; }
    public Guid SellerId { get; set; }
    public Guid BuyerId { get; set; }
    public string Image { get; set; }
    public string Data { get; set; }
    public DateTime CreatedAt { get; set; }
}