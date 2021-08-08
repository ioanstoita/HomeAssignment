using HA.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HA.Services
{
    public interface IRebateService
    {
        Task<Rebate> AddRebate(Rebate rebate);
        Task DeleteRebate(Rebate rebate);
        /// <summary>
        /// Get all rebates of a retailer.
        /// </summary>
        /// <param name="RetailerName">Retailer name</param>
        /// <returns></returns>
        Task<List<Rebate>> GetAllRetailerRebatesAsync(string RetailerName);
        /// <summary>
        /// Get all rebates of a customer.
        /// </summary>
        /// <param name="CustomerName">Customer name</param>
        /// <returns></returns>
        Task<List<Rebate>> GetAllCustomerRebatesAsync(string CustomerName);
    }
}