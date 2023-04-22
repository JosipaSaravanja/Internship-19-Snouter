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


    public async Task<Location> GetLocationById(Guid id)
    {
        return await Task.FromResult(_context.Locations.FirstOrDefault(x => x.Id == id));
    }

    public async Task<List<Location>> GetAllLocations()
    {
        return await Task.FromResult(_context.Locations.ToList());
    }

    public async Task<bool> PostLocation(Location location)
    {
        try
        {
            await _context.Locations.AddAsync(location);
            return await _context.SaveChangesAsync() > 0;
        }
        catch (DbUpdateException)
        {
            return false;
        }
    }

    public async Task<bool> PutLocation(Location location)
    {
        try
        {
            var locationToDelete = await GetLocationById(location.Id);
            _context.Locations.Remove(location);
            await _context.Locations.AddAsync(location);
            return await _context.SaveChangesAsync() > 0;
        }
        catch (DbUpdateException)
        {
            return false;
        }
    }

    public async Task<bool> DeleteLocation(Guid id)
    {
        try
        {
            var location = await GetLocationById(id);
            _context.Locations.Remove(location);
            return await _context.SaveChangesAsync() > 0;
        }
        catch (DbUpdateException)
        {
            return false;
        }
    }
}