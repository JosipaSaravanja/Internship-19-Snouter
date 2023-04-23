namespace ClassLibrary1.Response.SubCategory;

public class PutSubcategoryResponse
{
    public GetSubCategoryResponse SubCategory { get; set; } 
    public bool IsCompleted { get; set; }
}