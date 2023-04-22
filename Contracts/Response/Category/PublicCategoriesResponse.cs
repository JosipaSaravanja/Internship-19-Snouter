using ClassLibrary1.Response.User;

namespace ClassLibrary1.Response.Category;

public class PublicCategoriesResponse
{
    public List<GetCategoryResponse> Categories { get; set; } = new List<GetCategoryResponse>();
}