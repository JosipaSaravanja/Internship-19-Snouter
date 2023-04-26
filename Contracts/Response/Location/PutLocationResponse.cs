using Contracts.Response.User;

namespace Contracts.Response.Location;

public class PutLocationResponse
{
    public GetLocationResponse Location { get; set; } = null!;
    public bool IsCompleted { get; set; }

}