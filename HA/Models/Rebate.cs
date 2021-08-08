using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HA.Models
{
    public class Rebate
    {
        public Guid Id { get; set; }

        public virtual ApplicationUser Retailer { get; set; }
        public virtual ApplicationUser Customer { get; set; }

        public double RebatePercent { get; set; }

        // Maybe expiry date || nr. of possible uses
        //public DateTime ExpiryDate { get; set; }
        //public int AvailableUsesCounter { get; set; }
    }
}
