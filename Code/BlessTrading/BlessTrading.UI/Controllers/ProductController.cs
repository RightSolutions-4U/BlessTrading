using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlessTrading.Common.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace BlessTrading.UI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //GET: SearchCars
        [HttpPost]
        public async Task<ActionResult> SearchProducts(IFormCollection data)
        {
            var qry="";
            if (data["textsearch"]!="")
            {
                qry = qry + " and (p.Name like '%" + data["textsearch"] + "%' or p.ShortDescription like '%" + data["textsearch"] + "%' or p.FullDescription like '%" + data["textsearch"] + "%')";
            }
            if (data["textsearch"] != "")
            {
                qry = qry + " and CategoryId=" + data["lstCategory"];
            }

            if (data["PriceFrom"] != "" && Int32.Parse(data["PriceFrom"]) > 0)
            {
                qry = qry + " and p.Price>=" + data["PriceFrom"];
            }
            if (data["PriceTo"] != "" && Int32.Parse(data["PriceTo"]) > 0)
            {
                qry = qry + " and p.Price<=" + data["PriceTo"];
            }

            LoadProductExt product = new LoadProductExt();
            var myContent = JsonConvert.SerializeObject(product);
            try
            {
                var data1 = new StringContent(myContent + qry, Encoding.UTF8, "application/json");
                UriBuilder builderC = new UriBuilder("https://localhost:44340/api/Products/SearchProducts?");
                builderC.Query = "sql=" + qry;
                var client = new HttpClient();
                HttpResponseMessage responseC = await client.GetAsync(builderC.Uri);
                if (responseC.IsSuccessStatusCode)
                {
                    var ProductExts = responseC.Content.ReadAsStringAsync().Result;
                    product.ProductExts = JsonConvert.DeserializeObject<productExt[]>(ProductExts); 
                    ViewBag.Product = product;
                    ViewBag.textsearch = data["textsearch"];
                    ViewBag.PriceFrom = data["PriceFrom"];
                    ViewBag.PriceTo = data["PriceTo"];
                }

                return View("ProductSearch", product);
            }
            catch (Exception)
            {
                Error err = new Error();
                err.ErrorMessage = "Sorry we found no products with these filters";
                ViewBag.Error = err;
                ViewBag.Product = null;
                return View("Error", err);
            }

        }
        public async Task<ActionResult> Details(int id)
        {
            Product product = new Product();
            var client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            UriBuilder builder = new UriBuilder("https://localhost:44340/api/Products/GetProductDetail?");

            builder.Query = "Id=" + id;
            HttpResponseMessage Res = await client.GetAsync(builder.Uri);
            if (Res.IsSuccessStatusCode)
            {
                //Storing the response details recieved from web api
                var Product1 = Res.Content.ReadAsStringAsync().Result;
                //Deserializing the response recieved from web api and storing into the SiteUser object 
                Product[] a = JsonConvert.DeserializeObject<Product[]>(Product1);
                ViewBag.Product = product;
                ViewBag.Error = null;
                return View("Single", a);
            }
            return View();
        }
    }
}
