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
                return View("Admin/AdminMain");
            }
            catch(Exception e )
            {
                ViewBag.msg = "Invalid UserId or Password with ENV" + env;
                return View("Admin/AdminLogin");
            }

        }
    }
}
