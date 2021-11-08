using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlessTrading.Common.Models
{
    public partial class AdmminUserRoles
    {
        public AdmminUserRoles()
        {

        }
        [Key]
        public int VRoleId  { get; set; }
        public int RoleId   { get; set; }
        public int RecId { get; set; }
    }
}
