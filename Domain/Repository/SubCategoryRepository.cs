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
    public async Task<SubCategory> GetSubCategoryById(Guid id, CancellationToken cancellationToken = default)
    {
        return await Task.FromResult(await _context.SubCategories.FirstOrDefaultAsync(x => x.Id == id, cancellationToken));
    }
    public async Task<List<SubCategory>> GetAllSubCategories()
    {
        return await Task.FromResult(_context.SubCategories.ToList());
    }
    public async Task<bool> PostSubCategory(SubCategory subCategory, CancellationToken cancellationToken = default)
    {
       
            await _context.SubCategories.AddAsync(subCategory);
            return await _context.SaveChangesAsync(cancellationToken) > 0;
        }
    public async Task<bool> PutSubCategory(SubCategory subCategory, CancellationToken cancellationToken = default)
    {
        try
        {
            var subCategoryToDelete = await GetSubCategoryById(subCategory.Id, cancellationToken);
            _context.SubCategories.Remove(subCategoryToDelete);
            await _context.SubCategories.AddAsync(subCategory);
            return await _context.SaveChangesAsync(cancellationToken) > 0;
        }
        catch 
        {
            return false;
        }
    }
    public async Task<bool> DeleteSubCategory(Guid id, CancellationToken cancellationToken = default)
    {
        try
        {
            var subCategory = await GetSubCategoryById(id, cancellationToken);
            _context.SubCategories.Remove(subCategory);
            return await _context.SaveChangesAsync(cancellationToken) > 0;
        }
        catch 
        {
            return false;
        }
    }
    
}