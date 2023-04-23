namespace ClassLibrary1.Response.User;

public class PostUserResponse
{
    public GetUserResponse User { get; set; } = null!;
    public bool IsCompleted { get; set; }
}