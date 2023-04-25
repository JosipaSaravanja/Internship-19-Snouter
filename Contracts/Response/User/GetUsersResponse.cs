
namespace Contracts.Response.User;

public class GetUsersResponse
{
    public List<GetUserResponse> Users { get; set; } = null!;
}