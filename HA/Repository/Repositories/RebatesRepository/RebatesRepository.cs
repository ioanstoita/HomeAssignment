using HA.Data;
using HA.Models;
using HA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HA.Repository.Repositories
{
    public class RebatesRepository : Repository<Rebate>, IRebateRepository
    {
        private readonly ApplicationDbContext _context;

        public RebatesRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Rebate> GetAllRetailerRebates(string RetailerName)
        {
            return _context.Set<Rebate>().Where(x => x.RetailerName == RetailerName).ToList<Rebate>();
        }

        public List<Rebate> GetAllCustomerRebates(string CustomerName)
        {
            return _context.Set<Rebate>().Where(x => x.CustomerName == CustomerName).ToList<Rebate>();
        }
    }
}
