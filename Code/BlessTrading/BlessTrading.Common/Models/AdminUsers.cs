using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlessTrading.Common.Models
{
    public partial class AdminUsers
    {
        public AdminUsers()
        {

        }
        [Key]

        public int RecId { get; set; }
        public string UserId { get; set; }
        public string Pwd { get; set; }
    }
}
