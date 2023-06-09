﻿using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repository;

public class ProductRepository
{
    private readonly SnouterContext _context;
    
    
    public ProductRepository(SnouterContext context)
    {
        _context = context;
    }
    public async Task<Product> GetProductById(Guid id)
    {
        return await Task.FromResult(_context.Products.FirstOrDefault(x => x.Id == id));
    }
    public async Task<List<Product>> GetAllProducts()
    {
        return await Task.FromResult(_context.Products.ToList());
    }
    public async Task<bool> PostProduct(Product product)
    {
     
            await _context.Products.AddAsync(product);
            return await _context.SaveChangesAsync() > 0;
    }
    public async Task<bool> PutProduct(Product product)
    {
        try
        {
            var productToDelete = await GetProductById(product.Id);
            _context.Products.Remove(productToDelete);
            await _context.Products.AddAsync(product);
            return await _context.SaveChangesAsync() > 0;
        }
        catch 
        {
            return false;
        }
    }
    public async Task<bool> DeleteProduct(Guid id)
    {
        try
        {
            var product = await GetProductById(id);
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync() > 0;
        }
        catch 
        {
            return false;
        }
    }
    public async Task<bool> UpdateBought (Guid id, Guid BuyerId)
    {
        try
        {
            if (BuyerId == Guid.Empty)
            {
                return false;
            }

            if (id == Guid.Empty)
            {
                return false;
            }

            var product = await GetProductById(id);
            if (product == null)
            {
                return false;
            }
            if (product.isSold)
            {
                return false;
            }
            product.isSold = true;
            product.BuyerId = BuyerId;
            return await _context.SaveChangesAsync() > 0;
        }
        catch 
        {
            return false;
        }
    }


}