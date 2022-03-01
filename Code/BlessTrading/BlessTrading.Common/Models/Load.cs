using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlessTrading.Common.Models
{ //By SM on Nov 12, 2020
    public class Load
    {
        public int ProductId { get; set; }
        public IEnumerable<Product> FeaturedProduct { get; set; }
        public IEnumerable<Product> NewProduct { get; set; }
        public IEnumerable<productExt> MainCat1 { get; set; }
        public IEnumerable<productExt> MainCat2 { get; set; }
        public IEnumerable<productExt> MainCat3 { get; set; }
        public IEnumerable<productExt> MainCat4 { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<Cart> Cart { get; set; }
    }
}