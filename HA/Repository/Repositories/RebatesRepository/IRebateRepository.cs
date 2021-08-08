using HA.Models;
using HA.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HA.Repository.Repositories
{
    public  interface IRebateRepository : IRepository<Rebate>
    {
        Task<List<Rebate>> GetAllRetailerRebates(string RetailerName);
        Task<List<Rebate>> GetAllCustomerRebates(string CustomerName);
    }
}