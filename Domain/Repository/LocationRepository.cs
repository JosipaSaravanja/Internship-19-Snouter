using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repository;

public class LocationRepository
{
    private readonly SnouterContext _context;

    public LocationRepository(SnouterContext context)
    {
        _context = context;
    }


    public async Task<Location> GetLocationById(Guid id, CancellationToken cancellationToken = default)
    {
        return await Task.FromResult(await _context.Locations.FirstOrDefaultAsync(x => x.Id == id, cancellationToken));
    }

    public async Task<List<Location>> GetAllLocations()
    {
        return await Task.FromResult(_context.Locations.ToList());
    }

    public async Task<bool> PostLocation(Location location, CancellationToken cancellationToken = default)
    {
        try
        {
            await _context.Locations.AddAsync(location);
            return await _context.SaveChangesAsync(cancellationToken) > 0;
        }
        catch 
        {
            return false;
        }
    }

    public async Task<bool> PutLocation(Location location, CancellationToken cancellationToken = default)
    {
        try
        {
            var locationToDelete = await GetLocationById(location.Id, cancellationToken);
            _context.Locations.Remove(locationToDelete);
            await _context.Locations.AddAsync(location);
            return await _context.SaveChangesAsync(cancellationToken) > 0;
        }
        catch 
        {
            return false;
        }
    }

    public async Task<bool> DeleteLocation(Guid id, CancellationToken cancellationToken = default)
    {
        try
        {
            var location = await GetLocationById(id, cancellationToken);
            _context.Locations.Remove(location);
            return await _context.SaveChangesAsync(cancellationToken) > 0;
        }
        catch 
        {
            return false;
        }
    }
}