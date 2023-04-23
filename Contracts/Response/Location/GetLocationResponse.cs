namespace ClassLibrary1.Response.Location;

public class GetLocationResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public List<Guid> Products { get; set; } = null!;
    public List<Guid> Users { get; set; } = null!;
}