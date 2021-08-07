using HA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HA.Data;
using HA.Repositories;

namespace HA.Services
{
    public class ProductService : IProductService
    {
        public IUnitOfWork _repository;

        public ProductService(IUnitOfWork repository)
        {
            _repository = repository;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            /*var products = await _context.Products.Where(x => x.Name.ToLower().Contains("birou")).Select(x => new Product
            {
                Price = x.Price
            }).ToListAsync();*/

            var products = await _repository.Products.GetAllAsync();

            return products;
        }

        public List<Product> GetAllProducts(string RetailerName)
        {
            return _repository.Products.GetAllProducts(RetailerName);
        }

        public async Task<Product> AddProduct(Product product)
        {
            _repository.Products.Add(product);
            await _repository.SaveChangesAsync();
            return product;
        }

        public async Task DeleteProduct(Product product)
        {
            _repository.Products.Remove(product);
            await _repository.SaveChangesAsync();
        }
    }
}
