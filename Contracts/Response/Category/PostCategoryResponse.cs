namespace Contracts.Response.Category;

public class PostCategoryResponse
{
    public GetCategoryResponse Category { get; set; }
    public bool IsCompleted { get; set; }
}