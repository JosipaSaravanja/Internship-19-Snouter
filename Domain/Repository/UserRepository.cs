using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repository;

public class UserRepository
{
    private readonly SnouterContext _context;
    
    public UserRepository(SnouterContext context)
    {
        _context = context;
    }
    public async Task<User> GetUserById(Guid id, CancellationToken cancellationToken = default)
    {
        return await Task.FromResult(await _context.Users.FirstOrDefaultAsync(x => x.Id == id, cancellationToken));
    }
    public async Task<List<User>> GetAllUsers()
    {
        return await Task.FromResult(_context.Users.ToList());
    }
    public async Task<bool> PostUser(User user, CancellationToken cancellationToken = default)
    {
        try
        {
            await _context.Users.AddAsync(user);
            return await _context.SaveChangesAsync(cancellationToken) > 0;
        }
        catch 
        {
            return false;
        }
    }
    public async Task<bool> PutUser(User user, CancellationToken cancellationToken = default)
    {
        try
        {
            var userToDelete = await GetUserById(user.Id, cancellationToken);
            _context.Users.Remove(userToDelete);
            await _context.Users.AddAsync(user);
            return await _context.SaveChangesAsync(cancellationToken) > 0;
        }
        catch 
        {
            return false;
        }
    }
    public async Task<bool> DeleteUser(Guid id, CancellationToken cancellationToken = default)
    {
        try
        {
            var user = await GetUserById(id, cancellationToken);
            _context.Users.Remove(user);
            return await _context.SaveChangesAsync(cancellationToken) > 0;
        }
        catch 
        {
            return false;
        }
    }

}