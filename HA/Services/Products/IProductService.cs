using HA.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HA.Services
{
    public interface IProductService
    {
        Task<Product> AddProduct(Product product);
        Task DeleteProduct(Product product);

        /// <summary>
        /// Get all products for a customer, with rebates applied.
        /// </summary>
        /// <param name="CustomerName">Customer name</param>
        /// <returns></returns>
        Task<List<Product>> GetAllCustomerProductsAsync(string CustomerName);
        Task<List<Product>> GetAllRetailerProductsAsync(string RetailerName);
    }
}