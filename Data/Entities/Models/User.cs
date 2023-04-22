namespace Data.Entities;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Bio { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }
    public Location? Location { get; set; }
    public Guid LocationId { get; set; }
    public ICollection<Product> Products { get; set; } = new List<Product>();
    public ICollection<Product> Purchases { get; set; } = new List<Product>();

}