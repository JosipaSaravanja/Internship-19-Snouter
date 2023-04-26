namespace Contracts.Response.User;

public class GetUserResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Bio { get; set; } = null!;
    public string Email { get; set; } = null!;
    public List<Guid> Products { get; set; } = null!;
    public List<Guid> Purchases { get; set; } = null!;
    public Guid LocationId { get; set; }
}