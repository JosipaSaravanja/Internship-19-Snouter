using ClassLibrary1.Request.User;
using ClassLibrary1.Response.User;
using Data;
using Data.Entities;

namespace Domain.Mappers;

public class UserMappers
{
    private readonly SnouterContext _context;

    public UserMappers(SnouterContext context)
    {
        _context = context;
    }

    public GetUserResponse UserToGetUserResponse(User user)
    {
        return new GetUserResponse
        {
            Id = user.Id,
            Email = user.Email,
            LocationId = user.LocationId,
            Name = user.Name,
            Bio = user.Bio,
            IsAdmin = user.IsAdmin,
            Products = _context.Products.Where(x => x.SellerId == user.Id).Select(x => x.Id).ToList(),
            Purchases = _context.Products.Where(x => x.BuyerId == user.Id).Select(x => x.Id).ToList()
        };
    }
    public User GetUserResponseToUser(PostUserRequest postUserRequest)
    {
        return new User
        {
            Id = Guid.NewGuid(),
            Email = postUserRequest.Email,
            LocationId = postUserRequest.LocationId,
            Name = postUserRequest.Name,
            Bio = postUserRequest.Bio,
            IsAdmin = postUserRequest.IsAdmin
        };
    }
}