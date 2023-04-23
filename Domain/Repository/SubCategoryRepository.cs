using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repository;

public class SubCategoryRepository
{
    private readonly SnouterContext _context;
    
    public SubCategoryRepository(SnouterContext context)
    {
        _context = context;
    }
    public async Task<SubCategory> GetSubCategoryById(Guid id)
    {
        return await Task.FromResult(_context.SubCategories.FirstOrDefault(x => x.Id == id));
    }
    public async Task<List<SubCategory>> GetAllSubCategories()
    {
        return await Task.FromResult(_context.SubCategories.ToList());
    }
    public async Task<bool> PostSubCategory(SubCategory subCategory)
    {
       
            await _context.SubCategories.AddAsync(subCategory);
            return await _context.SaveChangesAsync() > 0;
        }
    public async Task<bool> PutSubCategory(SubCategory subCategory)
    {
        try
        {
            var subCategoryToDelete = await GetSubCategoryById(subCategory.Id);
            _context.SubCategories.Remove(subCategoryToDelete);
            await _context.SubCategories.AddAsync(subCategory);
            return await _context.SaveChangesAsync() > 0;
        }
        catch 
        {
            return false;
        }
    }
    public async Task<bool> DeleteSubCategory(Guid id)
    {
        try
        {
            var subCategory = await GetSubCategoryById(id);
            _context.SubCategories.Remove(subCategory);
            return await _context.SaveChangesAsync() > 0;
        }
        catch 
        {
            return false;
        }
    }
    
}