using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HA.Models
{
    public class Rebate
    {
        public Guid Id { get; set; }

        public string RetailerName { get; set; }
        public string CustomerName { get; set; }

        public double RebateValue { get; set; }
        public double RebatePercent { get; set; }




        // if empty     -> valid for all customers
        // if not empty -> valid for that customer
        //public string CustomerName { get; set; }

        // 0 -> value   discount $
        // 1 -> percent discount %
        //public byte RebateType { get; set; }
        //public double RebateValue { get; set; }

        //public string ProductId { get; set; }


        // Volume discount;
        // if 0 -> ignore;
        // if > 0 -> discount will apply only if customers buys more products than this threshold
        //public int VolumeDiscountMinThreshold { get; set; }

        // Discount for one product only
        //public Guid ProductId { get; set; }
    }
}
