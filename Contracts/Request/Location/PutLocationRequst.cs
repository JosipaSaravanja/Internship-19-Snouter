namespace ClassLibrary1.Request.Location;

public class PutLocationRequst
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}