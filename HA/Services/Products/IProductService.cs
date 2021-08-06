using HA.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HA.Services
{
    public interface IProductService
    {
        Task<Product> AddProduct(Product product);
        Task DeleteProduct(Product product);
        Task<List<Product>> GetSomeData();
    }
}