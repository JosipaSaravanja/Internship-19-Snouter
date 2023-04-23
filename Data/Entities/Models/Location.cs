namespace Data.Entities;

public class Location
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public ICollection<Product> Products { get; set; } = new List<Product>();
}