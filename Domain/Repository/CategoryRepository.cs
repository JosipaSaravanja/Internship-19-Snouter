using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repository;

public class CategoryRepository
{
    private readonly SnouterContext _context;
    
    public CategoryRepository(SnouterContext context)
    {
        _context = context;
    }
    public async Task<Category> GetCategoryById(Guid id, CancellationToken cancellationToken = default)
    {
        return await Task.FromResult(await _context.Categories.FirstOrDefaultAsync(x => x.Id == id, cancellationToken));
    }
    public async Task<List<Category>> GetAllCategories()
    {
        return await Task.FromResult(_context.Categories.ToList());
    }
    public async Task<bool> PostCategory(Category category, CancellationToken cancellationToken = default)
    {
        try
        {
            await _context.Categories.AddAsync(category);
            return await _context.SaveChangesAsync(cancellationToken) > 0;
        }
        catch 
        {
            return false;
        }
    }
    public async Task<bool> PutCategory(Category category, CancellationToken cancellationToken = default)
    {
        try
        {
            var categoryToDelete = await GetCategoryById(category.Id, cancellationToken);
            _context.Categories.Remove(categoryToDelete);
            await _context.Categories.AddAsync(category);
            return await _context.SaveChangesAsync(cancellationToken) > 0;
        }
        catch 
        {
            return false;
        }
    }
    public async Task<bool> DeleteCategory(Guid id, CancellationToken cancellationToken = default)
    {
        try
        {
            var category = await GetCategoryById(id, cancellationToken);
            _context.Categories.Remove(category);
            return await _context.SaveChangesAsync(cancellationToken) > 0;
        }
        catch 
        {
            return false;
        }
    }
    
}