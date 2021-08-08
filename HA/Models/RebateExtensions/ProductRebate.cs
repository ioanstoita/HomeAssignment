using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HA.Models.RebateExtensions
{
    /// <summary>
    /// Rebate available for only one product
    /// </summary>
    public class ProductRebate
    {
        public virtual Product Product { get; set; }
    }
}
