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
        Task<List<Product>> GetAllProductsAsync(string RetailerName);
    }
}
