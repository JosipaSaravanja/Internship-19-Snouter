using Contracts.Request.Location;
using Contracts.Response.Location;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
public class LocationController : ControllerBase
{
    private readonly LocationServices _locationServices;
    public LocationController(LocationServices locationServices)
    {
        _locationServices = locationServices;
    }
    [HttpGet(Routes.Location.GetAll)]
    public async Task<ActionResult<GetLocationResponse>> GetAllLocations()
    {
        var response = await _locationServices.GetAllLocations();
        if (response.Locations == null) return NotFound();
        return Ok(response);
    }
    [HttpGet(Routes.Location.Get)]
    public async Task<ActionResult<GetLocationResponse>> GetLocationById([FromRoute] Guid id)
    {
        var response = await _locationServices.GetLocationById(id);
        if (response == null) return NotFound();
        return Ok(response);
    }
    [HttpPost(Routes.Location.Post)]
    public async Task<ActionResult<PostLocationResponse>> PostLocation([FromBody] PostLocationRequest postLocationRequest)
    {
        var response = await _locationServices.PostLocation(postLocationRequest);
        if (response.Location == null) return NotFound();
        return Ok(response);
    }
    [HttpPut(Routes.Location.Put)]
    public async Task<ActionResult<PutLocationResponse>> PutLocation([FromRoute] Guid id, [FromBody] PostLocationRequest request)
    {
        var putLocationRequest = new PutLocationRequst
        {
            Id = id,
            Name = request.Name,
            Latitude = request.Latitude,
            Longitude = request.Longitude
        };
        var response = await _locationServices.PutLocation(putLocationRequest);
        if (response.Location == null) return NotFound(response);
        return Ok(response);
    }
    [HttpDelete(Routes.Location.Delete)]
    public async Task<ActionResult<DeleteLocationResponse>> DeleteLocation(Guid id)
    {
        var response = await _locationServices.DeleteLocation(id);
        if (!response.IsCompleted) return NotFound();
        return Ok(response);
    }

}
