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
    public async Task<Category> GetCategoryById(Guid id)
    {
        return await Task.FromResult(_context.Categories.FirstOrDefault(x => x.Id == id));
    }
    public async Task<List<Category>> GetAllCategories()
    {
        return await Task.FromResult(_context.Categories.ToList());
    }
    public async Task<bool> PostCategory(Category category)
    {
        try
        {
            await _context.Categories.AddAsync(category);
            return await _context.SaveChangesAsync() > 0;
        }
        catch 
        {
            return false;
        }
    }
    public async Task<bool> PutCategory(Category category)
    {
        try
        {
            var categoryToDelete = await GetCategoryById(category.Id);
            _context.Categories.Remove(categoryToDelete);
            await _context.Categories.AddAsync(category);
            return await _context.SaveChangesAsync() > 0;
        }
        catch 
        {
            return false;
        }
    }
    public async Task<bool> DeleteCategory(Guid id)
    {
        try
        {
            var category = await GetCategoryById(id);
            _context.Categories.Remove(category);
            return await _context.SaveChangesAsync() > 0;
        }
        catch 
        {
            return false;
        }
    }
    
}