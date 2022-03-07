using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlessTrading.Common.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public int count { get; set; }
        public string Attributes { get; set; }

    }
}
