using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HA.Models
{
    /// <summary>
    /// Volume discounts, applicable when buying more products at once
    /// </summary>
    public class VolumeRebate : Rebate
    {
        public int VolumeDiscount_min { get; set; }
        public int VolumeDiscount_max { get; set; }
    }
}
