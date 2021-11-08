using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlessTrading.Common.Models
{
    public partial class Roles
    {
        public Roles()
        {

        }
        [Key]
        public int RoleId { get; set; }
        public string RoleDescription { get; set; }
    }
}
