using HA.Data;
using HA.Models;
using HA.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HA.Repository.Repositories
{
    public class RebatesRepository : Repository<Rebate>, IRebateRepository
    {
        private readonly new ApplicationDbContext _context;

        public RebatesRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Rebate>> GetAllRetailerRebates(string RetailerName)
        {
            return await _context.Rebates.Include(x => x.Customer).Where(x => x.Retailer.UserName == RetailerName).ToListAsync();
        }

        public async Task<List<Rebate>> GetAllCustomerRebates(string CustomerName)
        {
            return await _context.Rebates.Include(x => x.Customer).Where(x => x.Customer.UserName == CustomerName).ToListAsync();
        }
    }
}
