namespace Contracts.Request.Category;

public class PutCategoryRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}