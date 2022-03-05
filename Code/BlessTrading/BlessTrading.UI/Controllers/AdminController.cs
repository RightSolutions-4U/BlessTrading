using BlessTrading.Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlessTrading.UI.Controllers
{
    public class AdminController : Controller
    {
        //for local
        /*private string env = Environment.GetEnvironmentVariable("ASPNETCORE_URLS");*/
        //for live
        private string env = "https://localhost:44340";

        public IActionResult Index()
        {
            return View("Admin/AdminLogin");
        }
        public async Task<ActionResult<AdminUsers>> CheckAdminLogin(IFormCollection collection)
        {
            try
            {
                var client = new HttpClient();
                client.DefaultRequestHeaders.Clear();
                UriBuilder builder = new UriBuilder(env + "/api/Admin/ValidateAdminUser?");

                builder.Query = "userid=" + collection["userid"] + "&pwd=" + collection["pwd"];
                HttpResponseMessage Res = await client.GetAsync(builder.Uri);
                var adminUser = Res.Content.ReadAsStringAsync().Result;
                var a = JsonConvert.DeserializeObject<AdminUsers>(adminUser);
                if (a.UserId == null)
                {
                    ViewBag.msg = "Invalid UserId or Password";
                    return View("Admin/AdminLogin");
                }
                ViewBag.UserId = a.UserId;
                ViewBag.env = env;
                /*if (HttpContext.Session.GetString("AdminUserId") == null)
                {*/
                HttpContext.Session.SetString("AdminUserId", a.RecId.ToString());
                /*}*/
                return View("Admin/AdminMain");
            }
            catch (Exception e)
            {
                ViewBag.msg = "Invalid UserId or Password with ENV" + env;
                return View("Admin/AdminLogin");
            }

        }
        public async Task<ActionResult<Vendor>> CustomerOrders()
        {
            try
            {
                var value = HttpContext.Session.GetString("AdminUserId");
                VendorProduct vendorproduct = new VendorProduct();

                var client1 = new HttpClient();
                //Load order items of the vendor
                UriBuilder builderOrder = new UriBuilder("https://localhost:44340/api/Vendors/GetOrderitemsByVendor?");
                builderOrder.Query = "VendorId=" + Int64.Parse(value);
                HttpResponseMessage Orderresponse = await client1.GetAsync(builderOrder.Uri);
                var Orderitems = Orderresponse.Content.ReadAsStringAsync().Result;
                vendorproduct.CustOrderItems = JsonConvert.DeserializeObject<CustOrderItems[]>(Orderitems);

                return View("../Shared/Admin/VendorOrders", vendorproduct);
            }
            catch (Exception e)
            {
                ViewBag.msg = "Error occured";
                return View("Admin/AdminLogin");
            }
        }
    }
}
