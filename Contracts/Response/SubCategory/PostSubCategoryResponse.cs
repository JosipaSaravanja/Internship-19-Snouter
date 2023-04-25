using Contracts.Response.SubCategory;

namespace Contracts.Response.SubCategory;

public class PostSubCategoryResponse
{
    public GetSubCategoryResponse SubCategory { get; set; } 
    public bool IsCompleted { get; set; }
}