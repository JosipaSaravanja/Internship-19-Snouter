using ClassLibrary1.Request.User;
using ClassLibrary1.Response.User;
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
    public async Task<ActionResult<GetUserResponse>> GetUserById([FromRoute] Guid id)
    {
        var response = await _userServices.GetUserById(id);
        if (response == null) return NotFound();
        return Ok(response);
    }
    [HttpPost(Routes.User.Post)]
    public async Task<ActionResult<PostUserResponse>> PostUser([FromBody] PostUserRequest postUserRequest)
    {
        var response = await _userServices.PostUser(postUserRequest);
        if (response.User == null) return NotFound();
        return Ok(response);
    }
    [HttpPut(Routes.User.Put)]
    public async Task<ActionResult<PutUserResponse>> PutUser([FromRoute] Guid id, [FromBody] PostUserRequest request)
    {
        var putUserRequest = new PutUserRequest
        {
            Id = id,
            Email = request.Email,
            LocationId = request.LocationId,
            Name = request.Name,
            Bio = request.Bio,
            IsAdmin = request.IsAdmin,
            Password = request.Password
        };
        var response = await _userServices.PutUser(putUserRequest);
        if (response.User == null) return NotFound();
        return Ok(response);
    }
    [HttpDelete(Routes.User.Delete)]
    public async Task<ActionResult<DeleteUserResponse>> DeleteUser(Guid id)
    {
        var response = await _userServices.DeleteUser(id);
        if (!response.IsCompleted) return NotFound();
        return Ok(response);
    }

}