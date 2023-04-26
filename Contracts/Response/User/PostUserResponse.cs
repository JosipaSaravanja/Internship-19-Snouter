namespace Contracts.Response.User;

public class PostUserResponse
{
    public GetUserResponse User { get; set; } = null!;
    public bool IsCompleted { get; set; }
}