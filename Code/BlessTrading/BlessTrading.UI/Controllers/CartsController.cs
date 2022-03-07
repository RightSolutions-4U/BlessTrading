using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using BlessTrading.Common.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http;

namespace BlessTrading.UI.Controllers
{
    public class CartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //Added by SM on Nov 25, 2020 for cart
        /*public ActionResult AddCart(int Id, string Name, decimal Price)*/
        public ActionResult AddCart(IFormCollection collection)
        {
            Cart cart = new Cart
            {
                Id = Convert.ToInt32(collection["Id"]),
                Name = collection["Name"],
                Price = Convert.ToDecimal(collection["Price"]),
                Attributes = collection["txtattributes"]
            };
            if (HttpContext.Session.GetString("cart") == null)
            {

                List<Cart> li = new List<Cart>();
                li.Add(cart);
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(li));
                /*ViewBag.cartcount = li.Count();*/
                TempData["cartcount"] = li.Count();
                HttpContext.Session.SetInt32("count", 1);
                ViewBag.cart = cart;

                /*return View("MyCart", (List<Cart>)li);*/
                return RedirectToAction("Index", "Home");
            }
            else //not empty
            {
                var value = HttpContext.Session.GetString("cart");
                List<Cart> li = JsonConvert.DeserializeObject<List<Cart>>(value);
                li.Add(cart);
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(li));
                HttpContext.Session.SetInt32("count", li.Count());
                var a = HttpContext.Session.GetInt32("count");
                ViewBag.cartcount = a;
                /*return View("MyCart", li);*/
                return RedirectToAction("Index", "Home");
            }
        }
        // GET: Carts/MyCart
        public async Task<ActionResult> MyCart(string CustId, int cartcount)
        {
            ViewBag.Message = (string)TempData["Message"];
            if (HttpContext.Session.GetString("cart") != null)
            {
                var value = HttpContext.Session.GetString("cart");
                List<Cart> li = JsonConvert.DeserializeObject<List<Cart>>(value);
                ViewBag.cartcount = li.Count();
                return View("MyCart", li);
            }
            if (CustId != null)
            {
                //if session["cart"] is empty    
                Cart cart = new Cart();
                var client = new HttpClient();
                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //Sending request to find web api REST service resource DeleteCart using HttpClient  
                UriBuilder builder = new UriBuilder("https://localhost:44340/api/Carts/GetCartofBuyer?");

                builder.Query = "CustId=" + CustId;
                HttpResponseMessage Res = await client.GetAsync(builder.Uri);
                if (Res.IsSuccessStatusCode)
                {
                    var cart1 = Res.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the cart list
                    Cart[] c = JsonConvert.DeserializeObject<Cart[]>(cart1);
                    ViewBag.Cart = c;

                    if (HttpContext.Session.GetString("cart") != null)
                    {
                        var value = HttpContext.Session.GetString("cart");
                        List<Cart> li = JsonConvert.DeserializeObject<List<Cart>>(value);
                        ViewBag.cartcount = li.Count();
                        return View("MyCart", li);
                    }
                    else
                    {
                        List<Cart> li = new List<Cart>(c);
                        HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(li));
                        ViewBag.cartcount = li.Count();
                        return View("MyCart", li);
                    }
                }//if not successful
                else
                {
                    Error err = new Error();
                    err.ErrorMessage = "Sorry there are no items in your cart  " + CustId;
                    ViewBag.Error = err;
                    ViewBag.Cart = null;
                    return View("Error", err);
                }
            }
            else //if customer not logged in
            {
                Error err = new Error();
                err.ErrorMessage = "Sorry there are no items in your cart  ";
                ViewBag.Error = err;
                ViewBag.Cart = null;
                TempData["cartcount"] = 0;
                return RedirectToAction("Index", "Home");
            }
        }
        public ActionResult CheckOut(string CustId)
        {
            if (Request.Cookies["userid"] != null)
            {
                if (HttpContext.Session.GetString("cart") != null)
                {
                    var value = HttpContext.Session.GetString("cart");
                    List<Cart> li = JsonConvert.DeserializeObject<List<Cart>>(value);
                    TempData["cartcount"] = li.Count();
                    return View("checkout", li);
                }
                else
                {
                    TempData["cartcount"] = 0;
                    return RedirectToAction("Index", "home");
                }
            }
            else
            {
                TempData["Message"] = "Please login or register before checkout";
                var value = HttpContext.Session.GetString("cart");
                List<Cart> li = JsonConvert.DeserializeObject<List<Cart>>(value);
                TempData["cartcount"] = li.Count();
                return RedirectToAction("MyCart", "Carts", new { CustId = "", cartcount = li.Count() });
            }
        }

        /* return View("checkout");*/

    }
    }
    


