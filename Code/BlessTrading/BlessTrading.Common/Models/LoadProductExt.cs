using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlessTrading.Common.Models
{ //By SM on Nov 12, 2020
    public class LoadProductExt
    {
        public int ProductId { get; set; }
        public IEnumerable<productExt> ProductExts { get; set; }
    }
}