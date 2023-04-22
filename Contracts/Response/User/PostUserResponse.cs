namespace ClassLibrary1.Response.User;

public class PostUserResponse
{
    public GetUserResponse Product { get; set; } = null!;
    public bool IsCompleted { get; set; }
}