namespace Contracts.Response.Category;

public class GetCategoryResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Guid> SubCategories { get; set; } = new List<Guid>();
    public List<Guid> Products { get; set; } = new List<Guid>();
}