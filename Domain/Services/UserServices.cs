using ClassLibrary1.Request.User;
using ClassLibrary1.Response.User;
using Domain.Mappers;
using Domain.Repository;

namespace Domain.Services;

public class UserServices
{
    private readonly UserRepository _userRepository;
    private readonly UserMappers _userMappers;
    
    public UserServices(UserRepository userRepository, UserMappers userMappers)
    {
        _userRepository = userRepository;
        _userMappers = userMappers;
    }
    public async Task<GetUserResponse> GetUserById(Guid id)
    {
        var user = await _userRepository.GetUserById(id);
        return _userMappers.UserToGetUserResponse(user);
    }
    public async Task<GetUsersResponse> GetAllUsers()
    {
        var users = await _userRepository.GetAllUsers();
        return new GetUsersResponse
        {
            Users = users.Select(x => _userMappers.UserToGetUserResponse(x)).ToList()
        };
    }
    public async Task<PostUserResponse> PostUser(PostUserRequest postUserRequest)
    {
        var user = _userMappers.PostUserRequestToUser(postUserRequest);
        var addition = await _userRepository.PostUser(user);
        if (!addition) return new PostUserResponse {IsCompleted = false, User = null};
        return new PostUserResponse()
        {
            IsCompleted = true,
            User = _userMappers.UserToGetUserResponse(user)
        };
    }
    public async Task<PutUserResponse> PutUser(PutUserRequest putUserRequest)
    {
        var user = _userMappers.PutUserRequestToUser(putUserRequest);
        var update = await _userRepository.PutUser(user);
        if (!update) return new PutUserResponse {IsCompleted = false, User = null};
        return new PutUserResponse()
        {
            IsCompleted = true,
            User = _userMappers.UserToGetUserResponse(user)
        };
    }
    public async Task<DeleteUserResponse> DeleteUser(Guid id)
    {
        var deletion = await _userRepository.DeleteUser(id);
        return new DeleteUserResponse {IsCompleted = deletion};
    }
    
}