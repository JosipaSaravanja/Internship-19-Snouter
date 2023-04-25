namespace Contracts.Response.Products;

public class GetProductResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public Guid LocationId { get; set; }
    public Guid CategoryId { get; set; }
    public Guid SubCategoryId { get; set; }
    public Guid SellerId { get; set; }
    public Guid BuyerId { get; set; }
    public List<string> Images { get; set; }
    public string Data { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsSold { get; set; }
}