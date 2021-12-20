using BlessTrading.Common.Models;
using BlessTrading.UI.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlessTrading.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        /*private string env = Environment.GetEnvironmentVariable("ASPNETCORE_URLS");*/
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<ActionResult> Index()
        {
            try
            {
                Load load = new Load();
                var clientF = new HttpClient();
                
                var urlF = "https://testapi.blesstrading.net/api/Products/GetFeatuedProducts";
                /*var urlF = env + "/api/Products/GetFeatuedProducts";*/

                var responseF = await clientF.GetAsync(urlF);
                var FeaturedProduct = responseF.Content.ReadAsStringAsync().Result;
                load.FeaturedProduct = JsonConvert.DeserializeObject<Product[]>(FeaturedProduct);

                var clientN = new HttpClient();
                var urlN = "https://testapi.blesstrading.net/api/Products/GetNewProducts"; 
                 /*var urlN = env + "/api/Products/GetNewProducts";*/
                 var responseN = await clientN.GetAsync(urlN);
                var NewProduct = responseN.Content.ReadAsStringAsync().Result;
                load.NewProduct = JsonConvert.DeserializeObject<Product[]>(NewProduct);
 /*               if (Request.Cookies["userid"] != null)
                {
                    var clientC = new HttpClient();
                    *//*UriBuilder builderC = new UriBuilder("https://localhost:44356/api/Customers/LoginID?");*//*
                    UriBuilder builderC = new UriBuilder("https://localhost:44356/api/Customers/LoginID?");
                    builderC.Query = "UserId=" + Request.Cookies["userid"];
                    HttpResponseMessage responseC = await clientC.GetAsync(builderC.Uri);
                    if (responseC.IsSuccessStatusCode)
                    {
                        var Users = responseC.Content.ReadAsStringAsync().Result;
                        load.Customer = JsonConvert.DeserializeObject<Customer>(Users);
                        ViewBag.UserName = load.Customer.Username;

                    }
                }
*/                ViewBag.Vendormessage = TempData["Vendormessage"];
                    return View("Index", load);
            }
            catch (Exception e)
            {
                Error err = new Error();
                err.ErrorMessage = e.Message;
                /*ViewBag.Error = err;*/
                ViewBag.err = e.Message;
                return View("Error");
            }
        }
/*        public IActionResult Contact()
        {
            return View("Contact");
        }
*/        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Common.Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
