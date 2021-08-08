using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HA.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        public virtual ApplicationUser Retailer { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }

        // if true, rebates won't apply to this product
        public bool IsStandardPrice { get; set; }

        [NotMapped] // used only when calculating rebates; not included in DB
        public double RebatePrice { get; set; }
    }
}
