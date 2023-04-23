using ClassLibrary1.Response.User;

namespace ClassLibrary1.Response.Location;

public class PutLocationResponse
{
    public GetLocationResponse Location { get; set; } = null!;
    public bool IsCompleted { get; set; }

}