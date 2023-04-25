using Contracts.Request.Location;
using Contracts.Response.Location;
using Domain.Mappers;
using Domain.Repository;
using Domain.Validation;
using FluentValidation;

namespace Domain.Services;

public class LocationServices
{
    private readonly LocationRepository _locationRepository;
    private readonly LocationMapper _locationMapper;
    private readonly LocationValidaton _locationValidaton;
    public LocationServices(LocationRepository locationRepository, LocationMapper locationMapper, LocationValidaton locationValidaton)
    {
        _locationRepository = locationRepository;
        _locationMapper = locationMapper;
        _locationValidaton = locationValidaton;
    }
    
    public async Task<GetLocationResponse> GetLocationById(Guid id)
    {
        var location = await _locationRepository.GetLocationById(id);
        return _locationMapper.LocationToGetLocationResponse(location);
    }
    
    public async Task<GetLocationsResponse> GetAllLocations()
    {
        var locations = await _locationRepository.GetAllLocations();
        return new GetLocationsResponse
        {
            Locations = locations.Select(x => _locationMapper.LocationToGetLocationResponse(x)).ToList()
        };
    }
    
    public async Task<PostLocationResponse> PostLocation(PostLocationRequest postLocationRequest)
    {
        var location = _locationMapper.PostLocationRequestToLocation(postLocationRequest);
        await _locationValidaton.ValidateAndThrowAsync(location);
        var addition = await _locationRepository.PostLocation(location);
        if (!addition) return new PostLocationResponse {IsCompleted = false, Location = null};
        return new PostLocationResponse()
        {
            IsCompleted = true,
            Location = _locationMapper.LocationToGetLocationResponse(location)
        };
    }
    
    public async Task<PutLocationResponse> PutLocation(PutLocationRequst putLocationRequest)
    {
        var location = _locationMapper.PutLocationRequestToLocation(putLocationRequest);
        await _locationValidaton.ValidateAndThrowAsync(location);
        var update = await _locationRepository.PutLocation(location);
        if (!update) return new PutLocationResponse {IsCompleted = false, Location = null};
        return new PutLocationResponse
        {
            IsCompleted = true,
            Location = _locationMapper.LocationToGetLocationResponse(location)
        };
    }
    
    public async Task<DeleteLocationResponse> DeleteLocation(Guid id)
    {
        var delete = await _locationRepository.DeleteLocation(id);
        if (!delete) return new DeleteLocationResponse {IsCompleted = false};
        return new DeleteLocationResponse {IsCompleted = true};
    }
}