using Contracts.Request.User;
using Contracts.Response.User;
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
            Products = _context.Products.Where(x => x.SellerId == user.Id).Select(x => x.Id).ToList(),
            Purchases = _context.Products.Where(x => x.BuyerId == user.Id).Select(x => x.Id).ToList()
        };
    }
    public User PostUserRequestToUser(PostUserRequest postUserRequest)
    {
        return new User
        {
            Id = Guid.NewGuid(),
            Email = postUserRequest.Email,
            LocationId = postUserRequest.LocationId,
            Name = postUserRequest.Name,
            Bio = postUserRequest.Bio,
            Password = postUserRequest.Password
        };
    }
    public User PutUserRequestToUser(PutUserRequest putUserRequest)
    {
        return new User
        {
            Id = putUserRequest.Id,
            Email = putUserRequest.Email,
            LocationId = putUserRequest.LocationId,
            Name = putUserRequest.Name,
            Bio = putUserRequest.Bio,
            Password =putUserRequest.Password
        };
    }
}