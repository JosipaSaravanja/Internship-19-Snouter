namespace ClassLibrary1.Response.Location;

public class GetLocationResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public List<Guid> Products { get; set; } = null!;
}