using Newtonsoft.Json.Linq;

namespace Data.Entities;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public List<string> ImageUrl { get; set; } = new List<string>();
    public Category? Category { get; set; }
    public SubCategory? SubCategory { get; set; }
    public Guid CategoryId { get; set; }
    public Guid SubCategoryId { get; set; }
    public Location? Location { get; set; }
    public Guid LocationId { get; set; }
    public User? Buyer { get; set; }
    public Guid BuyerId { get; set; }
    public User? Seller { get; set; }
    public Guid SellerId { get; set; }
    public DateTime CreatedAt { get; set; }
    public JObject Data { get; set; }
    public bool isSold { get; set; } = false;

}