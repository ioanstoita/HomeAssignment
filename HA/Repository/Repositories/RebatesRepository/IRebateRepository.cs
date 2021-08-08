using HA.Models;
using HA.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HA.Repository.Repositories
{
    public  interface IRebateRepository : IRepository<Rebate>
    {
        /// <summary>
        /// Get the rebates created by a specific retailer.
        /// </summary>
        /// <param name="RetailerName"></param>
        /// <returns></returns>
        Task<List<Rebate>> GetAllRetailerRebates(string RetailerName);
        /// <summary>
        /// Get the rebates available to specific customer.
        /// </summary>
        /// <param name="CustomerName"></param>
        /// <returns></returns>
        Task<List<Rebate>> GetAllCustomerRebates(string CustomerName);
    }
}