using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlessTrading.Common.Models;
using Microsoft.AspNetCore.Cors;

//using EnableCorsAttribute = System.Web.Http.Cors.EnableCorsAttribute;

namespace BlessTrading.API.Controllers
{
    [EnableCors("CorsApi")]
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProductsController : ControllerBase
    {
        private readonly blesstradingContext _context;

        public ProductsController(blesstradingContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            /*return await _context.Products.ToListAsync();*/
            return await _context.Products.Where(a => a.Deleted == false && a.IsActive==true)
                .ToListAsync();
        }

        // GET: api/Products/5
        [HttpGet("GetProduct")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            //var sproduct = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(id.ToString());
            var product = await _context.Products.FindAsync(id);
           
            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // GET: api/Products/5
        [HttpGet("GetProductWithCat")]
        public async Task<ActionResult<Product>> GetProductWithCat(int id)
        {
            //var sproduct = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(id.ToString());
            var product = await _context.Products.Include(i => i.ProductCategoryMappings)
                                .FirstOrDefaultAsync(i => i.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        [HttpGet("GetCategories")]
        public IEnumerable<ProductCategory> GetCategories()
        {
            try
            {
                var Category =  _context.ProductCategories
                .FromSqlRaw("Execute dbo.GetCategories")
                .ToList();
                return Category;
            }
            catch (Exception e)
            {
                /*incase of no category*/
                return null;
            }
        }
        [HttpGet("GetCategory")]
        public IEnumerable<ProductCategory> GetCategory(int CId)
        {
            try
            {
                var Category = _context.ProductCategories
                .FromSqlRaw("Execute dbo.GetCategory  {0}", CId);
                return Category;
            }
            catch (Exception e)
            {
                /*incase of no category*/
                return null;
            }
        }
        // GET: api/Products/5
        [HttpGet("GetProductDetail")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductDetail(int Id)
        {
            try {
                var product = await _context.Products
                                             .Where(a => a.Id == Id)
                                             .Include(a => a.ProductPictureMappings)
                                             .ThenInclude(f => f.Picture)
                                             .Include(g => g.ProductProductAttributeMappings)
                                                .ThenInclude(h => h.ProductAttributeValues)
                                                .ThenInclude(f => f.ProductAttributes)
                                             .ToListAsync();
                return product;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        //added by SM on Nov 20, 2020
        // GET: api/Products/5
        [HttpGet("GetProductByVendor1")]
        public IEnumerable<ProductByVendor> GetProductByVendor1(int VendorId)
        {   
            /*Added by Mohtashim on Dec 21, 2020*/
            try
            {
                var product = _context.ProductByVendors
                .FromSqlRaw("Execute dbo.GetProductByVendor {0}", VendorId)
                .ToList();
               
                return product;
            }
            catch(Exception e )
            {
                /*if the vendor dont have any product*/
                return null;
            }
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost("PutProduct1")]
        public async Task<IActionResult> PutProduct1([FromBody] Product myproduct)
        {

            _context.Entry(myproduct).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(myproduct.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        //GET: api/PostProduct 
        [HttpPost("PostProduct")]
        public async Task<ActionResult<Product>> PostProduct([FromBody] dynamic myproduct)
        {
            try
            { 
            var sProduct = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(myproduct.ToString());
            int catId = sProduct.Categoryid;
            Product product = new Product
            {
                Name = sProduct.ProductName,
                ShortDescription = sProduct.ShortDescription,
                FullDescription = sProduct.FullDescription,
                CreatedOnUtc = DateTime.UtcNow,
                ProductTypeId = 1,
                Price = sProduct.Price,
                Discount = sProduct.Discount,
                ParentGroupedProductId = 1,
                VisibleIndividually = true,
                ProductTemplateId = 1,
                VendorId = 1007,
                ShowOnHomepage = true,
                AllowCustomerReviews = true,
                ApprovedRatingSum = 1,
                NotApprovedRatingSum = 1,
                ApprovedTotalReviews = 1,
                NotApprovedTotalReviews = 1,
                SubjectToAcl = true,
                LimitedToStores = true,
                IsGiftCard = true,
                GiftCardTypeId = 1,
                RequireOtherProducts = true,
                AutomaticallyAddRequiredProducts = true,
                IsDownload = true,
                DownloadId = 0,
                UnlimitedDownloads = true,
                MaxNumberOfDownloads = 50000,
                DownloadActivationTypeId = 0,
                HasSampleDownload = true,
                SampleDownloadId = 0,
                HasUserAgreement = true,
                IsRecurring = true,
                RecurringCycleLength = 1,
                RecurringCyclePeriodId = 1,
                RecurringTotalCycles = 1,
                IsRental = true,
                RentalPriceLength = 1,
                RentalPricePeriodId = 1,
                IsShipEnabled = true,
                IsFreeShipping = true,
                ShipSeparately = true,
                AdditionalShippingCharge = 1,
                DeliveryDateId = 1,
                IsTaxExempt = true,
                TaxCategoryId = 1,
                IsTelecommunicationsOrBroadcastingOrElectronicServices = true,
                ManageInventoryMethodId = 1,
                ProductAvailabilityRangeId = 1,
                UseMultipleWarehouses = true,
                WarehouseId = 1,
                StockQuantity = 1,
                DisplayStockAvailability = true,
                DisplayStockQuantity = true,
                MinStockQuantity = 1,
                LowStockActivityId = 1,
                NotifyAdminForQuantityBelow = 1,
                BackorderModeId = 1,
                AllowBackInStockSubscriptions = true,
                OrderMinimumQuantity = 1,
                OrderMaximumQuantity = 1,
                AllowAddingOnlyExistingAttributeCombinations = true,
                NotReturnable = true,
                DisableBuyButton = true,
                DisableWishlistButton = true,
                AvailableForPreOrder = true,
                CallForPrice = true,
                OldPrice = 1,
                ProductCost = 1,
                CustomerEntersPrice = true,
                MinimumCustomerEnteredPrice = 1,
                MaximumCustomerEnteredPrice = 1,
                BasepriceEnabled = true,
                BasepriceAmount = 1,
                BasepriceUnitId = 1,
                BasepriceBaseAmount = 1,
                BasepriceBaseUnitId = 1,
                MarkAsNew = true,
                HasTierPrices = true,
                HasDiscountsApplied = true,
                Weight = 1,
                Length = 1,
                Width = 1,
                Height = 1,
                DisplayOrder = 1,
                Published = true,
                Deleted = false,
                UpdatedOnUtc = DateTime.UtcNow,
                IsActive = true,
            };
            return await PostProductJson(product, catId);
            }
            catch (Exception e)
            {
                Product p = new Product();
                return await PostProductJson(p  , 21);
            }
        }
        private async Task<ActionResult<Product>> PostProductJson(Product product, int Categoryid)
        {
         
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
            ProductCategoryMapping productMapping = new ProductCategoryMapping
            {
                CategoryId = Categoryid,
                ProductId = product.Id
            };
            _context.ProductCategoryMappings.Add(productMapping);
            //Picture picture = new Picture
            //{
            //    MimeType = "MME",
            //    SeoFilename = "noimage.jpeg",
            //    IsNew = true,
            //    VirtualPath = "/productimages/",
            //    ProductId = product.Id
            //};
            //_context.Pictures.Add(picture);
            await _context.SaveChangesAsync();
            
            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
            
            //return NoContent();
        }

        /* // DELETE: api/Products/5
         [HttpDelete("{id}")]
         public async Task<ActionResult<Product>> DeleteProduct(int id)
         {
             var product = await _context.Products.FindAsync(id);
             if (product == null)
             {
                 return NotFound();
             }

             _context.Products.Remove(product);
             await _context.SaveChangesAsync();

             return product;
         }*/
        // DELETE: api/Products/5
        [HttpPost("DeleteProduct1")]
        public async Task<ActionResult<Product>> DeleteProduct1([FromBody] dynamic myproduct)
        {
            var sProduct = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(myproduct.ToString());
            int Id = sProduct.id;
            var product = await _context.Products.FindAsync(Id);
            if (product == null)
            {
                return NotFound();
            }
            product.Deleted = true;
            /*_context.Products.Remove(product);*/
            _context.Products.Update(product);
            await _context.SaveChangesAsync();

            return product;
        }
        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }

        // GET: api/Products
        [HttpGet("GetFeatuedProducts")]
        public async Task<ActionResult<IEnumerable<Product>>> GetFeatuedProducts()
        {
            try
            {
                var product = await _context.Products.OrderByDescending(a => a.MarkAsNew == true
                                )
                                .Where(a => a.Deleted == false && a.IsActive == true)
                                .Include(a => a.ProductPictureMappings)
                                .ThenInclude(f => f.Picture).Take(4)
                                .ToListAsync();
                return product;
            }
            catch(Exception e)
            {
                return null;
            }
        }
        // GET: api/Products
        [HttpGet("GetNewProducts")]
        public async Task<ActionResult<IEnumerable<Product>>> GetNewProducts()
        {
      
            
            var product = await _context.Products.OrderByDescending(a => a.CreatedOnUtc 
                           )
                            .Where(a => a.Deleted == false && a.IsActive==true)
                           .Include(a => a.ProductPictureMappings)
                           .ThenInclude(f => f.Picture).Take(8)
                           
                           .ToListAsync();
            return product;
        }

        [HttpGet("GetProductsByCat")]
        public IEnumerable<productExt> GetProductsByCat(int CatId)
        {
            /*Added by Mohtashim on Dec 21, 2020*/
            try
            {
                int CategoryId = CatId;
                var productExt = _context.productExts
                .FromSqlRaw("Execute dbo.GetProductByCategoryId {0}", CatId)
                .ToList();

                return productExt;
            }
            catch (Exception e)
            {
                /*if the vendor dont have any product*/
                return null;
            }
        }

        [HttpGet("GetProductsByMainCat")]
        public IEnumerable<productExt> GetProductsByMainCat(int CatId)
        {
            /*Added by Mohtashim on FEB 13, 2022*/
            try
            {
                int CategoryId = CatId;
                var productExt = _context.productExts
                .FromSqlRaw("Execute dbo.GetProductByMainCategory {0}", CatId)
                .ToList();
                /* var product = await _context.Products.OrderByDescending(a => a.MarkAsNew == true
                                 )
                                 .Where(a => a.Deleted == false && a.IsActive == true)
                                 *//*.Include(a => a.ProductPictureMappings)
                                     .ThenInclude(f => f.Picture).Take(4)*//*
                                 .Include(a => a.ProductCategoryMappings)
                                     .ThenInclude(g => g.Category.Where(h => h.ParentCategoryId == CatId))
                                 .ToListAsync();*/

                return productExt;
            }
            catch (Exception e)
            {
                /*if the vendor dont have any product*/
                return null;
            }
        }
        [HttpGet("GetCategoryByProduct")]
        public IEnumerable<productExt> GetCategoryByProduct(int Id)
        {
            /*Added by Mohtashim on Dec 21, 2020*/
            try
            {
                int ProductId = Id;
                var productExt = _context.productExts
                .FromSqlRaw("Execute dbo.GetCategoryIdByProduct {0}", ProductId)
                .ToList();

                return productExt;
            }
            catch (Exception e)
            {
                /*if the vendor dont have any product*/
                return null;
            }
        }
        [HttpGet("SearchProducts")]
        public IEnumerable<productExt> GetProductsByCat(string sql)
        {
            /*Added by Mohtashim on Feb 21, 2022*/
            try
            {
                var productExt = _context.productExts
                .FromSqlRaw("Execute dbo.PrSearch {0}", sql)
                .ToList();

                return productExt;
            }
            catch (Exception e)
            {
                /*if the vendor dont have any product*/
                return null;
            }
        }
    }
}
