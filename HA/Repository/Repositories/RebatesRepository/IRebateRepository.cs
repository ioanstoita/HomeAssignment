using HA.Models;
using HA.Repositories;
using System.Collections.Generic;

namespace HA.Repository.Repositories
{
    public  interface IRebateRepository : IRepository<Rebate>
    {
        List<Rebate> GetAllRetailerRebates(string RetailerName);
        List<Rebate> GetAllCustomerRebates(string CustomerName);
    }
}