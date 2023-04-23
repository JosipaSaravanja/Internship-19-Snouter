namespace ClassLibrary1.Request.User;

public class PutUserRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Bio { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public Guid LocationId { get; set; }
    public bool IsAdmin { get; set; }
}