using HA.Data;
using HA.Models;
using HA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HA.Repository.Repositories
{
    public class ProductsRepository : Repository<Product>, IProductsRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts(string RetailerName)
        {
            List<Product> products = _context.Set<Product>().Where(x => x.RetailerName == RetailerName).ToList<Product>();
            return products;
        }
    }
}
