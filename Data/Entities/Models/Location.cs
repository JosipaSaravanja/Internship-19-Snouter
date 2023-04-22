namespace Data.Entities;

public class Location
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }

    public ICollection<Product> Products { get; set; } = new List<Product>();
}