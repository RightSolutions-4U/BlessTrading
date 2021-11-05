using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlessTrading.Common.Models
{
    public partial class VendorRoles
    {
        public VendorRoles()
        {

        }
        public int VRoleId  { get; set; }
        public int RoleId   { get; set; }
        public int VendorId { get; set; }
    }
}
