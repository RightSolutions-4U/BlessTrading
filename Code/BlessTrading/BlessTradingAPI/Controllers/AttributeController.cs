using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlessTrading.Common.Models;
using Microsoft.AspNetCore.Cors;

namespace BlessTradingAPI.Controllers
{
    [EnableCors("CorsApi")]
    [Route("api/[controller]")]
    [ApiController]
    public class AttributeController : ControllerBase
    {
        private readonly blesstradingContext _context;

        public AttributeController(blesstradingContext context)
        {
            _context = context;
        }

        // GET: api/Attribute/ProductId
        [HttpGet("GetProductAttribute")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductAttribute(int ProductId)
        {
            try
            {
                var product = await _context.Products
                             .Where(a => a.Id == ProductId)
                             .Include(g => g.ProductProductAttributeMappings)
                                .ThenInclude(h => h.ProductAttributeValues)
                                .ThenInclude(f => f.ProductAttributes)
                             .ToListAsync();
                return product;
            }
            catch (Exception e)
            {
                return null;

            }
        }
    }
}
