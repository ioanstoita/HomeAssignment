using HA.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HA.Services
{
    public interface IRebateService
    {
        Task<Rebate> AddRebate(Rebate rebate);
        Task DeleteRebate(Rebate rebate);
        List<Rebate> GetAllRetailerRebates(string RetailerName);
        List<Rebate> GetAllCustomerRebates(string CustomerName);
    }
}