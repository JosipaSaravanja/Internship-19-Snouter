namespace Contracts.Request.User;

public class PostUserRequest
{
    public string Name { get; set; } = null!;
    public string Bio { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public bool IsAdmin { get; set; } 
    public Guid LocationId { get; set; }
}