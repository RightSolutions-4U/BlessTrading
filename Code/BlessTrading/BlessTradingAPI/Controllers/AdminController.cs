using BlessTrading.Common.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlessTradingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly blesstradingContext _context;

        public AdminController(blesstradingContext context)
        {
            _context = context;
        }
        // GET: api/Addresses
        [HttpGet("GetAdminUsers")]
        public async Task<ActionResult<IEnumerable<AdminUsers>>> GetAdminUsers()
        {
            return await _context.AdminUsers.ToListAsync();
        }

        // GET: api/Addresses/5
        [HttpGet("GetAdminUser")]
        public async Task<ActionResult<AdminUsers>> GetAdminUser(int id)
        {
            var adminUsers = await _context.AdminUsers.FindAsync(id);

            if (adminUsers == null)
            {
                return NotFound();
            }

            return adminUsers;
        }

        //Added by Mohtashim on Nov 29, 2020
        [HttpGet("ValidateAdminUser")]
        public ActionResult<AdminUsers> ValidateAdminUser(string userid, string pwd)
        {
            bool AdminUserExists;
            AdminUserExists = _context.AdminUsers.Any(e => e.UserId == userid && e.Pwd == pwd);

            if (AdminUserExists == false)
            {
                return NotFound();
            }


            var AdminUser = _context.AdminUsers.SingleOrDefault(e => e.UserId == userid);
            return AdminUser;

        }
        private bool AdminUsersExists(int id)
        {
            return _context.AdminUsers.Any(e => e.RecId == id);
        }

    }
}
