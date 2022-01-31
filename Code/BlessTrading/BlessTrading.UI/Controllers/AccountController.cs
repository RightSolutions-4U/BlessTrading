using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BlessTrading.Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlessTrading.UI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Customer Registration
        public ActionResult Index()
        {
            return View("~/Views/Shared/register.cshtml");
        }

        /*public ActionResult Index(string pagename)
        {
            return View("~/Views/Shared/login.cshtml");
        }*/

        public ActionResult Login()
        {
            return View("~/Views/Shared/login.cshtml");
        }



        // GET: AccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult<Customer>> Create(IFormCollection collection)
        {
            try

            {
                Address address = new Address
                {
                    FirstName = collection["FirstName"],
                    LastName = collection["LastName"],
                    Address1 = collection["StreetAddress1"],
                    Address2 = collection["StreetAddress2"],
                    City = collection["city"],
                    Email = collection["email"],
                    CreatedOnUtc = DateTime.UtcNow,
                    ZipPostalCode = collection["ZipCode"],
                    PhoneNumber = collection["phoneno"]
                };
                string output = JsonConvert.SerializeObject(address);
                var data = new StringContent(output, Encoding.UTF8, "application/json");
                var url = "https://localhost:44340/api/Addresses/PostAddress";

                var client = new HttpClient();
                var response = await client.PostAsync(url, data);
                var Address = response.Content.ReadAsStringAsync().Result;
                var BillingAddress1 = JsonConvert.DeserializeObject<Address>(Address);
                var BillingAddressId = BillingAddress1.Id;
                //ViewBag.SiteUsers = a;
                //PostAddress

                Customer customer = new Customer
                {
                    Username = collection["Email"],
                    Email = collection["Email"],
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
                    Password = collection["Password"],
                };

                output = JsonConvert.SerializeObject(customer);
                data = new StringContent(output, Encoding.UTF8, "application/json");
                url = "https://localhost:44340/api/Customers";

                client = new HttpClient();
                response = await client.PostAsync(url, data);
                var Customer = response.Content.ReadAsStringAsync().Result;
                var a = JsonConvert.DeserializeObject<Customer>(Customer);
                ViewBag.Customer = a;
                //return RedirectToAction(nameof(Index));
                
                return View("../Home/Index");
            }
            catch
            {
                return View("Index");
            }
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View("~/Views/Shared/login.cshtml");
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        //By Mohtashim on Nov 29, 2020
        public async Task<ActionResult<Customer>> CheckLogin(IFormCollection collection)
        {
            Customer cutomer = new Customer();
            var client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            UriBuilder builder = new UriBuilder("https://localhost:44340/api/Customers/ValidateCustomer?");
            /*UriBuilder builder = new UriBuilder("https://localhost:44340/api/Customers/ValidateCustomer?");*/
            builder.Query = "email=" + collection["Email"] + "&UserPassword=" + collection["Password"];
            HttpResponseMessage Res = await client.GetAsync(builder.Uri);
            var Customer = Res.Content.ReadAsStringAsync().Result;
            var a = JsonConvert.DeserializeObject<Customer>(Customer);
            //Store in cookies
            if (a.Email == null)
            {
                ViewBag.message = "Invalid UserId or Password";
                return View("~/Views/Shared/login.cshtml");
            }
            if (Request.Cookies["userid"] == null)
            {
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddDays(50);
                option.IsEssential = true;
                Response.Cookies.Append("userid", a.Id.ToString(), option);
            }
            Load load = new Load();
            //Featured--field name MarkAsNew
            var clientF = new HttpClient();
            var urlF = "https://localhost:44340/api/Products/GetFeatuedProducts";
            var responseF = await clientF.GetAsync(urlF);
            var FeaturedProduct = responseF.Content.ReadAsStringAsync().Result;
            load.FeaturedProduct = JsonConvert.DeserializeObject<Product[]>(FeaturedProduct);
            //New Arrivals--field name Recent
            var clientN = new HttpClient();
            var urlN = "https://localhost:44340/api/Products/GetNewProducts";
            var responseN = await clientN.GetAsync(urlN);
            var NewProduct = responseN.Content.ReadAsStringAsync().Result;
            load.NewProduct = JsonConvert.DeserializeObject<Product[]>(NewProduct);
            //Customers
            if (Request.Cookies["userid"] != null)
            {
                var clientC = new HttpClient();
                UriBuilder builderC = new UriBuilder("https://localhost:44340/api/Customers/LoginID?");
                builderC.Query = "UserId=" + Request.Cookies["userid"];
                HttpResponseMessage responseC = await clientC.GetAsync(builderC.Uri);
                if (responseC.IsSuccessStatusCode)
                {
                    var Users = responseC.Content.ReadAsStringAsync().Result;
                    load.Customer = JsonConvert.DeserializeObject<Customer>(Users);
                    ViewBag.UserName = load.Customer.Username;
                }
                else
                {
                    ViewBag.message = "Invalid UserId or Password";
                    return View("~/Views/Shared/login.cshtml");
                }
            }
                return View("../Home/Index", load);
        }
        // GET: AccountController/Delete/5
        public async Task<ActionResult> Logout()
        {
                /*CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddDays(50);*/
                if (Request.Cookies["userid"] != null)
                {
                    Response.Cookies.Delete("userid");
                }
            Load load = new Load();
            //Featured--field name MarkAsNew
            var clientF = new HttpClient();
            var urlF = "https://localhost:44340/api/Products/GetFeatuedProducts";
            var responseF = await clientF.GetAsync(urlF);
            var FeaturedProduct = responseF.Content.ReadAsStringAsync().Result;
            load.FeaturedProduct = JsonConvert.DeserializeObject<Product[]>(FeaturedProduct);
            //New Arrivals--field name Recent
            var clientN = new HttpClient();
            var urlN = "https://localhost:44340/api/Products/GetNewProducts";
            var responseN = await clientN.GetAsync(urlN);
            var NewProduct = responseN.Content.ReadAsStringAsync().Result;
            load.NewProduct = JsonConvert.DeserializeObject<Product[]>(NewProduct);
            //Customers
            if (Request.Cookies["userid"] != null)
            {
                var clientC = new HttpClient();
                UriBuilder builderC = new UriBuilder("https://localhost:44340/api/Customers/LoginID?");
                builderC.Query = "UserId=" + Request.Cookies["userid"];
                HttpResponseMessage responseC = await clientC.GetAsync(builderC.Uri);
                if (responseC.IsSuccessStatusCode)
                {
                    var Users = responseC.Content.ReadAsStringAsync().Result;
                    load.Customer = JsonConvert.DeserializeObject<Customer>(Users);
                    ViewBag.UserName = load.Customer.Username;
                }
                else
                {
                    ViewBag.message = "Invalid UserId or Password";
                    return View("~/Views/Shared/login.cshtml", load);
                }
            }
            return View("../Home/Index",load);
        }
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
