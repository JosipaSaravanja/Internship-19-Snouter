using Contracts.Response.SubCategory;

namespace Contracts.Response.SubCategory;

public class GetSubCategoriesResponse
{
    public List<GetSubCategoryResponse> SubCategories { get; set; }
}