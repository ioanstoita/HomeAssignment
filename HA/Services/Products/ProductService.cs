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
        private readonly IUnitOfWork _repository;

        public ProductService(IUnitOfWork repository)
        {
            _repository = repository;
        }

        public async Task<List<Product>> GetAllCustomerProductsAsync(string CustomerName)
        {
            List<Product> products = await _repository.Products.GetAllProductsWithRebatesAsync(CustomerName);
            //List<Rebate> rebates = await _repository.Rebates.GetAllCustomerRebates(CustomerName);

            foreach(Product product in products)
            {
                if(!product.StandardPrice)
                {
                    List<Rebate> matchRebates = product.Retailer.Rebates.Where(x => x.Retailer.UserName != CustomerName).ToList();
                    if(matchRebates.Count > 0)
                    {
                        double maxRebate = matchRebates.Max(y => y.RebatePercent);

                        product.RebatePrice = product.Price - (product.Price/100) * maxRebate;
                        product.RebatePrice = Math.Round(product.RebatePrice, 2);
                    }
                }
            }

            return products;
        }

        public async Task<List<Product>> GetAllRetailerProductsAsync(string RetailerName)
        {
            return await _repository.Products.GetAllProductsAsync(RetailerName);
        }

        public async Task<Product> AddProduct(Product product)
        {
            if(product.Price > 0 && product.Retailer.UserName is not null)
                //todo: check claims
            {
                _repository.Products.Add(product);
                await _repository.SaveChangesAsync();
            }
            return product;
        }

        public async Task DeleteProduct(Product product)
        //todo: check claims
        {
            _repository.Products.Remove(product);
            await _repository.SaveChangesAsync();
        }
    }
}
