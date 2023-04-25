using Contracts.Request.User;
using Contracts.Response.User;
using Domain.Mappers;
using Domain.Repository;
using Domain.Validation;
using FluentValidation;

namespace Domain.Services;

public class UserServices
{
    private readonly UserRepository _userRepository;
    private readonly UserMappers _userMappers;
    private readonly UserValidaton _userValidaton;
    
    public UserServices(UserRepository userRepository, UserMappers userMappers, UserValidaton userValidaton)
    {
        _userRepository = userRepository;
        _userMappers = userMappers;
        _userValidaton = userValidaton;
    }
    public async Task<GetUserResponse> GetUserById(Guid id, CancellationToken cancellationToken = default)
    {
        var user = await _userRepository.GetUserById(id, cancellationToken);
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
    public async Task<PostUserResponse> PostUser(PostUserRequest postUserRequest, CancellationToken cancellationToken = default)
    {
        var user = _userMappers.PostUserRequestToUser(postUserRequest);
        await _userValidaton.ValidateAndThrowAsync(user);
        var addition = await _userRepository.PostUser(user, cancellationToken);
        if (!addition) return new PostUserResponse {IsCompleted = false, User = null};
        return new PostUserResponse()
        {
            IsCompleted = true,
            User = _userMappers.UserToGetUserResponse(user)
        };
    }
    public async Task<PutUserResponse> PutUser(PutUserRequest putUserRequest, CancellationToken cancellationToken = default)
    {
        var user = _userMappers.PutUserRequestToUser(putUserRequest);
        await _userValidaton.ValidateAndThrowAsync(user);
        var update = await _userRepository.PutUser(user, cancellationToken);
        if (!update) return new PutUserResponse {IsCompleted = false, User = null};
        return new PutUserResponse()
        {
            IsCompleted = true,
            User = _userMappers.UserToGetUserResponse(user)
        };
    }
    public async Task<DeleteUserResponse> DeleteUser(Guid id, CancellationToken cancellationToken = default)
    {
        var deletion = await _userRepository.DeleteUser(id, cancellationToken);
        return new DeleteUserResponse {IsCompleted = deletion};
    }
    
}