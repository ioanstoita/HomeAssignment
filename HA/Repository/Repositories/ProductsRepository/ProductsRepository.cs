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

        public async Task<List<Product>> GetAllProductsAsync(string RetailerName)
        {
            List<Product> products = await _context.Products.Where(x => x.Retailer.UserName == RetailerName).ToListAsync();
            return products;
        }

        public async Task<List<Product>> GetAllProductsWithRebatesAsync(string CustomerName)
        {
            //error
            List<Product> products = await _context.Products.Include(x => x.Retailer).ThenInclude(x => x.Rebates.Where(y => y.Customer.UserName == CustomerName)).ToListAsync();
            return products;
        }
    }
}
