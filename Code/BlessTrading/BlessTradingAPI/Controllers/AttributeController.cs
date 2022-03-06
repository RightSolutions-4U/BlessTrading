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
        public async Task<ActionResult<IEnumerable<ProductAttribute>>> GetProductAttribute(int ProductId)
        {
            try
            {
                var attribute = _context.ProductAttributes
                .FromSqlRaw("Execute dbo.GetProductAttributes  {0}", ProductId)
                .ToList();
                return attribute;
            }
            catch (Exception e)
            {
                /*incase of no category*/
                return null;
            }
        }
    }
}
