using HA.Models;
using HA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HA.Services
{
    public class RebateService : IRebateService
    {
        public IUnitOfWork _repository;

        public RebateService(IUnitOfWork repository)
        {
            _repository = repository;
        }

        public async Task<Rebate> AddRebate(Rebate rebate)
        {
            if(rebate.RebatePercent > 0 && rebate.RebatePercent < 100
                && rebate.RetailerName is not null
                && rebate.CustomerName is not null)
            {
                _repository.Rebates.Add(rebate);
                await _repository.SaveChangesAsync();
            }
            return rebate;
        }

        public async Task DeleteRebate(Rebate rebate)
        {
            _repository.Rebates.Remove(rebate);
            await _repository.SaveChangesAsync();
        }

        public List<Rebate> GetAllCustomerRebates(string CustomerName)
        {
            return _repository.Rebates.GetAllCustomerRebates(CustomerName);
        }

        public List<Rebate> GetAllRetailerRebates(string RetailerName)
        {
            return _repository.Rebates.GetAllRetailerRebates(RetailerName);
        }
    }
}
