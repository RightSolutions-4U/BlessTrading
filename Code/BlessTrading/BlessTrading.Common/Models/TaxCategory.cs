using System;
using System.Collections.Generic;

#nullable disable

namespace BlessTrading.Common.Models
{
    public partial class TaxCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
