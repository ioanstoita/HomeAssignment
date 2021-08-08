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


        // false - can't cumulate with other rebates
        // true  - can cumulate with other rebates
        //public bool Cumulative { get; set; }


        // rebate expiry date
        //public DateTime ExpiryDate { get; set; }
        // rebate expiry 
        //public bool ExpiresAfterNumberOfUses { get; set; }
        //public int NumberOfUsesAvailable { get; set; }


        // volume discount thresholds
        //public int VolumeDiscount_min { get; set; }
        //public int VolumeDiscount_max { get; set; }


        // if empty  -> rebase for all retailer's products
        // if !empty -> rebase for this product only
        //public Guid ProductId { get; set; }



        // 0 -> value   discount $
        // 1 -> percent discount %
        //public byte   RebateType { get; set; }
        //public double RebateValue { get; set; }
    }
}
