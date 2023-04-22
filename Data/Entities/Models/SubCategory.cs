using Newtonsoft.Json.Schema;

namespace Data.Entities;

public class SubCategory
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public JSchema Schema { get; set; }
    
    public string Description { get; set; }
    public Category? Category { get; set; }
    public Guid CategoryId { get; set; }
    public ICollection<Product> Products { get; set; } = new List<Product>();
}