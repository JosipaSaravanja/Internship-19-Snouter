namespace Contracts.Request.Products;

public class PutProductsRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public double Price { get; set; }
    public Guid LocationId { get; set; }
    public Guid CategoryId { get; set; }
    public Guid SellerId { get; set; }
    public Guid SubCategoryId { get; set; }
    public List<string> Images { get; set; } = null!;
    public string Data { get; set; } = null!;
    public bool IsSold { get; set; }
}