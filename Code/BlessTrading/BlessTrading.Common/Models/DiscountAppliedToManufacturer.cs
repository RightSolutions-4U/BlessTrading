using System;
using System.Collections.Generic;

#nullable disable

namespace BlessTrading.Common.Models
{
    public partial class DiscountAppliedToManufacturer
    {
        public int DiscountId { get; set; }
        public int ManufacturerId { get; set; }

        public virtual Discount Discount { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
