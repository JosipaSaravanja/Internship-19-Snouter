namespace ClassLibrary1.Response.User;

public class PutUserResponse
{
    public GetUserResponse User { get; set; } = null!;
    public bool IsCompleted { get; set; }
}