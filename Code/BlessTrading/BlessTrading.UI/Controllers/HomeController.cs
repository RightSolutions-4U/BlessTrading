using BlessTrading.Common.Models;
using BlessTrading.UI.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
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
                
                var urlF = "https://localhost:44340/api/Products/GetFeatuedProducts";
                /*var urlF = env + "/api/Products/GetFeatuedProducts";*/

                var responseF = await clientF.GetAsync(urlF);
                var FeaturedProduct = responseF.Content.ReadAsStringAsync().Result;
                load.FeaturedProduct = JsonConvert.DeserializeObject<Product[]>(FeaturedProduct);

                var clientC1 = new HttpClient();
                UriBuilder builderC1 = new UriBuilder("https://localhost:44340/api/Products/GetProductsByMainCat?");
                /*UriBuilder builderC = new UriBuilder("https://localhost:44356/api/Customers/LoginID?");*/
                builderC1.Query = "CatId=18";
                HttpResponseMessage responseC1 = await clientC1.GetAsync(builderC1.Uri);
                if (responseC1.IsSuccessStatusCode)
                {
                    var MainCat1 = responseC1.Content.ReadAsStringAsync().Result;
                    load.MainCat1 = JsonConvert.DeserializeObject<productExt[]>(MainCat1);
                }

                var clientC2 = new HttpClient();
                UriBuilder builderC2 = new UriBuilder("https://localhost:44340/api/Products/GetProductsByMainCat?");
                /*UriBuilder builderC = new UriBuilder("https://localhost:44356/api/Customers/LoginID?");*/
                builderC2.Query = "CatId=29";
                HttpResponseMessage responseC2 = await clientC1.GetAsync(builderC2.Uri);
                if (responseC2.IsSuccessStatusCode)
                {
                    var MainCat2 = responseC2.Content.ReadAsStringAsync().Result;
                    load.MainCat2 = JsonConvert.DeserializeObject<productExt[]>(MainCat2);
                }

                var clientC3 = new HttpClient();
                UriBuilder builderC3 = new UriBuilder("https://localhost:44340/api/Products/GetProductsByMainCat?");
                /*UriBuilder builderC = new UriBuilder("https://localhost:44356/api/Customers/LoginID?");*/
                builderC3.Query = "CatId=19";
                HttpResponseMessage responseC3 = await clientC1.GetAsync(builderC3.Uri);
                if (responseC3.IsSuccessStatusCode)
                {
                    var MainCat3 = responseC3.Content.ReadAsStringAsync().Result;
                    load.MainCat3 = JsonConvert.DeserializeObject<productExt[]>(MainCat3);
                }

                var clientC4 = new HttpClient();
                UriBuilder builderC4 = new UriBuilder("https://localhost:44340/api/Products/GetProductsByMainCat?");
                /*UriBuilder builderC = new UriBuilder("https://localhost:44356/api/Customers/LoginID?");*/
                builderC4.Query = "CatId=26";
                HttpResponseMessage responseC4 = await clientC1.GetAsync(builderC4.Uri);
                if (responseC4.IsSuccessStatusCode)
                {
                    var MainCat4 = responseC4.Content.ReadAsStringAsync().Result;
                    load.MainCat4 = JsonConvert.DeserializeObject<productExt[]>(MainCat4);
                }
                var clientN = new HttpClient();
                var urlN = "https://localhost:44340/api/Products/GetNewProducts"; 
                 /*var urlN = env + "/api/Products/GetNewProducts";*/
                 var responseN = await clientN.GetAsync(urlN);
                var NewProduct = responseN.Content.ReadAsStringAsync().Result;
                load.NewProduct = JsonConvert.DeserializeObject<Product[]>(NewProduct);
                if (Request.Cookies["userid"] != null)
                {
                    var clientC = new HttpClient();
                    UriBuilder builderC = new UriBuilder("https://localhost:44340/api/Customers/LoginID?");
                    /*UriBuilder builderC = new UriBuilder("https://localhost:44356/api/Customers/LoginID?");*/
                    builderC.Query = "UserId=" + Request.Cookies["userid"];
                    HttpResponseMessage responseC = await clientC.GetAsync(builderC.Uri);
                    if (responseC.IsSuccessStatusCode)
                    {
                        var Users = responseC.Content.ReadAsStringAsync().Result;
                        load.Customer = JsonConvert.DeserializeObject<Customer>(Users);
                        ViewBag.UserName = load.Customer.Username;

                    }
                }
                ViewBag.Vendormessage = TempData["Vendormessage"];
                if( TempData["cartcount"] != null )
                { 
                    ViewBag.cartcount = TempData["cartcount"];
                }
                else
                {
                    ViewBag.cartcount = 0;
                }
                
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
        // POST: AccountController/Create
        [HttpPost]

        public async Task<ActionResult<Customer>> CreateCustomer([FromBody] dynamic MyCustomer)
        {
            try

            {
                var sMyCustomer = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(MyCustomer.ToString());
                Address address = new Address
                {
                    FirstName = sMyCustomer.FirstName,
                    LastName = sMyCustomer.LastName,
                    Address1 = sMyCustomer.StreetAddress1,
                    Address2 = sMyCustomer.StreetAddress2,
                    City = sMyCustomer.City,
                    Email = sMyCustomer.Email,
                    CreatedOnUtc = DateTime.UtcNow,
                    ZipPostalCode = sMyCustomer.ZipCode,
                    PhoneNumber = sMyCustomer.phoneno
                };
                string output = JsonConvert.SerializeObject(address);
                var data = new StringContent(output, Encoding.UTF8, "application/json");
                /*var url = "https://localhost:44356/api/Addresses";*/
                var url = "https://localhost:44356/api/Addresses";

                var client = new HttpClient();
                var response = await client.PostAsync(url, data);
                var Address = response.Content.ReadAsStringAsync().Result;
                var BillingAddress1 = JsonConvert.DeserializeObject<Address>(Address);
                var BillingAddressId = BillingAddress1.Id;

                Customer customer = new Customer
                {
                    Username = sMyCustomer.Email,
                    Email = sMyCustomer.Email,
                    EmailToRevalidate = "",
                    SystemName = "",
                    BillingAddressId = BillingAddress1.Id,
                    ShippingAddressId = BillingAddress1.Id,
                    AdminComment = "",
                    IsTaxExempt = true,
                    AffiliateId = 0,
                    VendorId = 0,
                    HasShoppingCartItems = false,
                    RequireReLogin = false,
                    FailedLoginAttempts = 0,
                    Active = true,
                    Deleted = false,
                    IsSystemAccount = false,
                    LastIpAddress = "",
                    CreatedOnUtc = DateTime.UtcNow,
                    RegisteredInStoreId = 1,
                    Password = sMyCustomer.Password
                };
                output = JsonConvert.SerializeObject(customer);
                data = new StringContent(output, Encoding.UTF8, "application/json");
                /*url = "https://localhost:44356/api/Customers";*/
                url = "https://localhost:44356/api/Customers";

                client = new HttpClient();
                response = await client.PostAsync(url, data);
                var Customer = response.Content.ReadAsStringAsync().Result;
                var a = JsonConvert.DeserializeObject<Customer>(Customer);
                ViewBag.Customer = a;
                ViewBag.UserName = a.Username;
                //Store in cookies
                if (Request.Cookies["userid"] == null)
                {
                    CookieOptions option = new CookieOptions();
                    option.Expires = DateTime.Now.AddDays(1);
                    option.IsEssential = true;
                    Response.Cookies.Append("userid", a.Id.ToString(), option);
                    ViewBag.UserName = a.Username;//Request.Cookies["userid"];
                    /* cookie code ends here*/
                }

                return View(a);
                //return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Common.Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
