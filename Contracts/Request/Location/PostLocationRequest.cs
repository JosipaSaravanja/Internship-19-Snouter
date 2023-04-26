namespace Contracts.Request.Location;

public class PostLocationRequest
{
    public string Name { get; set; } = null!;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    
}