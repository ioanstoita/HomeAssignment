using HA.Models;
using HA.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HA.Services
{
    public class RebateService : IRebateService
    {
        private readonly IUnitOfWork _repository;
        private readonly UserManager<ApplicationUser> _userManager;

        public RebateService(IUnitOfWork repository, UserManager<ApplicationUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }

        public async Task<Rebate> AddRebate(Rebate rebate)
        {
            ApplicationUser customer = await _userManager.FindByNameAsync(rebate.Customer.UserName);
            
            if (rebate.RebatePercent > 0 && rebate.RebatePercent < 100
                && rebate.Retailer is not null
                && customer is not null)
            {
                rebate.Customer = customer;
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

        public async Task<List<Rebate>> GetAllCustomerRebatesAsync(string CustomerName)
        {
            return await _repository.Rebates.GetAllCustomerRebates(CustomerName);
        }

        public async Task<List<Rebate>> GetAllRetailerRebatesAsync(string RetailerName)
        {
            return await _repository.Rebates.GetAllRetailerRebates(RetailerName);
        }
    }
}
