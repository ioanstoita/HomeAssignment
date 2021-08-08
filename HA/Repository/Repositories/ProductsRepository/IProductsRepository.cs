using HA.Models;
using HA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HA.Repository.Repositories
{
    public interface IProductsRepository : IRepository<Product>
    {
        /// <summary>
        /// Get the products of a specific retailer.
        /// </summary>
        /// <param name="RetailerName"></param>
        /// <returns></returns>
        Task<List<Product>> GetAllProductsAsync(string RetailerName);
        /// <summary>
        /// Get all the products together with the available rebates/discounts
        /// applicable to a specific customer.
        /// </summary>
        /// <param name="CustomerName"></param>
        /// <returns></returns>
        Task<List<Product>> GetAllProductsWithRebatesAsync(string CustomerName);
    }
}
