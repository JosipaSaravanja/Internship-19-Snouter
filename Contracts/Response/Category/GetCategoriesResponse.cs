using Contracts.Response.User;

namespace Contracts.Response.Category;

public class GetCategoriesResponse
{
    public List<GetCategoryResponse> Categories { get; set; } = new List<GetCategoryResponse>();
}