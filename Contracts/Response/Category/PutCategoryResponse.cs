namespace Contracts.Response.Category;

public class PutCategoryResponse
{
    public GetCategoryResponse Category { get; set; }
    public bool IsCompleted { get; set; }
}