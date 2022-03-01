using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlessTrading.Common.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace BlessTrading.UI.Controllers
{
    public class MenuController : Controller
    {
        public async Task<ActionResult<IEnumerable<productExt>>> Index(int CatId)

        {
            if (HttpContext.Session.GetString("cart") != null)
            {
                var value = HttpContext.Session.GetString("cart");
                List<Cart> li = JsonConvert.DeserializeObject<List<Cart>>(value);
                ViewBag.cartcount = li.Count();
            }
            else
            {
                ViewBag.cartcount = 0;
            }
            ProductCategory cat = new ProductCategory();
            var client = new HttpClient();
            var url = "https://localhost:44340/api/Products/GetCategory?CId=" + CatId;
            var response = await client.GetAsync(url);
            var cat1 = response.Content.ReadAsStringAsync().Result;
            var cat2 = JsonConvert.DeserializeObject<ProductCategory[]>(cat1);
            ViewBag.cat = cat2[0].CatName;
            LoadProductExt load = new LoadProductExt();
            //Featured--field name MarkAsNew
            var clientF = new HttpClient();
            var urlF = "https://localhost:44340/api/Products/GetProductsByCat?CatId=" + CatId;
            var responseF = await clientF.GetAsync(urlF);
            var ProductExts = responseF.Content.ReadAsStringAsync().Result;
            load.ProductExts = JsonConvert.DeserializeObject<productExt[]>(ProductExts);

            return View("ProductByCat1", load);
        }
    }
}
