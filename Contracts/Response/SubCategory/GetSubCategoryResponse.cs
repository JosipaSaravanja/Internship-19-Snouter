namespace Contracts.Response.SubCategory;

public class GetSubCategoryResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid CategoryId { get; set; }
    public string Schema { get; set; }
    public List<Guid> Products { get; set; } = new List<Guid>();
    
}