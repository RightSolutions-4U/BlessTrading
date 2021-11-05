using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlessTrading.Common.Models
{
    public class CompletedOrder
    {
        [Key]
        public int Id { get; set; }
        public int OrderCompleted { get; set; }
        public int OrderId { get; set; }
    }
}
