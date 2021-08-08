using HA.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HA.Services
{
    public interface IProductService
    {
        Task<Product> AddProduct(Product product);
        Task DeleteProduct(Product product);
        Task<List<Product>> GetAllProductsAsync();
        /// <summary>
        /// Get all products of a retailer.
        /// </summary>
        /// <param name="RetailerName">Retailer name</param>
        /// <returns></returns>
        List<Product> GetAllProducts(string RetailerName);
        /// <summary>
        /// Get all products for a customer, with rebates applied.
        /// </summary>
        /// <param name="CustomerName">Customer name</param>
        /// <returns></returns>
        Task<List<Product>> GetAllProductsAsync(string CustomerName);
    }
}