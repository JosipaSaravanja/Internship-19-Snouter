using ClassLibrary1.Response.User;

namespace ClassLibrary1.Response.Category;

public class GetCategoriesResponse
{
    public List<GetCategoryResponse> Categories { get; set; } = new List<GetCategoryResponse>();
}