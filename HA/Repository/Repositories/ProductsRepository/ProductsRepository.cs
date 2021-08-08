using HA.Data;
using HA.Models;
using HA.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HA.Repository.Repositories
{
    public class ProductsRepository : Repository<Product>, IProductsRepository
    {
        private readonly new ApplicationDbContext _context;

        public ProductsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllProducts(string RetailerName)
        {
            List<Product> products = await _context.Products.Where(x => x.RetailerName == RetailerName).ToListAsync();
            return products;
        }
    }
}
