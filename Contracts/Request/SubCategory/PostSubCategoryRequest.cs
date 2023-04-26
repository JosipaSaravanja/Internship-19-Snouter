namespace Contracts.Request.SubCategory;

public class PostSubCategoryRequest
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid CategoryId { get; set; }
    public string Schema { get; set; }
}