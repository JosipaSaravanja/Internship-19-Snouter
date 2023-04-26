using Contracts.Response.User;

namespace Contracts.Response.Location;

public class PostLocationResponse
{
    public GetLocationResponse Location { get; set; } = null!;
    public bool IsCompleted { get; set; }
}