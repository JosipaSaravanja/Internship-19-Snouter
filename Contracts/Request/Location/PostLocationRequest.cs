namespace ClassLibrary1.Request.Location;

public class PostLocationRequest
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    
}