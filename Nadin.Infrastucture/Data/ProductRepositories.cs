﻿using Microsoft.EntityFrameworkCore;
using Nadin.Domain.Contract;
using Nadin.Domain.Model;
using Nadin.Infrastucture.Context;

namespace Nadin.Infrastucture.Data;

public class ProductRepositories : IProductRepositories
{
    
        private readonly NadinContext _context;

        public ProductRepositories(NadinContext context)
        {
            _context = context;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }
}