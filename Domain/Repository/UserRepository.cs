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
    public async Task<User> GetUserById(Guid id)
    {
        return await Task.FromResult(_context.Users.FirstOrDefault(x => x.Id == id));
    }
    public async Task<List<User>> GetAllUsers()
    {
        return await Task.FromResult(_context.Users.ToList());
    }
    public async Task<bool> PostUser(User user)
    {
        try
        {
            await _context.Users.AddAsync(user);
            return await _context.SaveChangesAsync() > 0;
        }
        catch 
        {
            return false;
        }
    }
    public async Task<bool> PutUser(User user)
    {
        try
        {
            var userToDelete = await GetUserById(user.Id);
            _context.Users.Remove(userToDelete);
            await _context.Users.AddAsync(user);
            return await _context.SaveChangesAsync() > 0;
        }
        catch 
        {
            return false;
        }
    }
    public async Task<bool> DeleteUser(Guid id)
    {
        try
        {
            var user = await GetUserById(id);
            _context.Users.Remove(user);
            return await _context.SaveChangesAsync() > 0;
        }
        catch 
        {
            return false;
        }
    }

}