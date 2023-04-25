using Contracts.Request.User;
using Contracts.Response.User;
using Domain.Mappers;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
public class UserController : ControllerBase
{
    private readonly UserServices _userServices;
    
    public UserController(UserServices userServices, UserMappers userMappers)
    {
        _userServices = userServices;
    }
    [HttpGet(Routes.User.GetAll)]
    public async Task<ActionResult<GetUserResponse>> GetAllUsers()
    {
        var response = await _userServices.GetAllUsers();
        if (response.Users == null) return NotFound();
        return Ok(response);
    }
    [HttpGet(Routes.User.Get)]
    public async Task<ActionResult<GetUserResponse>> GetUserById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var response = await _userServices.GetUserById(id, cancellationToken);
        if (response == null) return NotFound();
        return Ok(response);
    }
    [HttpPost(Routes.User.Post)]
    public async Task<ActionResult<PostUserResponse>> PostUser([FromBody] PostUserRequest postUserRequest, CancellationToken cancellationToken)
    {
        var response = await _userServices.PostUser(postUserRequest, cancellationToken);
        if (response.User == null) return NotFound();
        return Ok(response);
    }
    [HttpPut(Routes.User.Put)]
    public async Task<ActionResult<PutUserResponse>> PutUser([FromRoute] Guid id, [FromBody] PostUserRequest request, CancellationToken cancellationToken)
    {
        var putUserRequest = new PutUserRequest
        {
            Id = id,
            Email = request.Email,
            LocationId = request.LocationId,
            Name = request.Name,
            Bio = request.Bio,
            Password = request.Password
        };
        var response = await _userServices.PutUser(putUserRequest, cancellationToken);
        if (response.User == null) return NotFound();
        return Ok(response);
    }
    [HttpDelete(Routes.User.Delete)]
    public async Task<ActionResult<DeleteUserResponse>> DeleteUser(Guid id, CancellationToken cancellationToken)
    {
        var response = await _userServices.DeleteUser(id, cancellationToken);
        if (!response.IsCompleted) return NotFound();
        return Ok(response);
    }

}