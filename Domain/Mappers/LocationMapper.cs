using ClassLibrary1.Request.Location;
using ClassLibrary1.Response.Location;
using Data;
using Data.Entities;

namespace Domain.Mappers;

public class LocationMapper
{
    private readonly SnouterContext _context;
    
    public LocationMapper(SnouterContext context)
    {
        _context = context;
    }
    public GetLocationResponse LocationToGetLocationResponse(Location location)
    {
        return new GetLocationResponse
        {
            Id = location.Id,
            Name = location.Name,
            Users = _context.Users.Where(x => x.LocationId == location.Id).Select(x => x.Id).ToList(),
            Products = _context.Products.Where(x => x.LocationId == location.Id).Select(x => x.Id).ToList(),
            Latitude = location.Latitude,
            Longitude = location.Longitude
        };
    }
    public Location GetLocationResponseToLocation(PostLocationRequest postLocationRequest)
    {
        return new Location
        {
            Id = Guid.NewGuid(),
            Name = postLocationRequest.Name,
            Latitude = postLocationRequest.Latitude,
            Longitude = postLocationRequest.Longitude
        };
    }
}