using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlessTrading.Common.Models;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace BlessTrading.UI.Controllers
{
    public class OrderController : Controller
    {
        public async Task<ActionResult<OrderItem>> Index()
        {
            if (Request.Cookies["userid"] != null)
            {
                VendorProduct vendorproduct = new VendorProduct();
                var client1 = new HttpClient();
                UriBuilder builderOrder = new UriBuilder("https://localhost:44340/api/OrderItems/GetCustomerOrderItems?");
                builderOrder.Query = "custid=" + Request.Cookies["userid"];
                HttpResponseMessage Orderresponse = await client1.GetAsync(builderOrder.Uri);
                var Orderitems = Orderresponse.Content.ReadAsStringAsync().Result;
                vendorproduct.CustOrderItems = JsonConvert.DeserializeObject<CustOrderItems[]>(Orderitems);

                return View("CustomerOrders", vendorproduct);
            }
            else
            {
                if (HttpContext.Session.GetString("cart") != null)
                {
                    var value = HttpContext.Session.GetString("cart");
                    List<Cart> li = JsonConvert.DeserializeObject<List<Cart>>(value);
                    TempData["cartcount"] = li.Count();
                }
                else
                {
                    TempData["cartcount"] = 0;
                }
                
                return RedirectToAction("Index","Home");
            }
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
        [HttpPost("CreateOrder")]
        /*[ValidateAntiForgeryToken]*/
        public async Task<ActionResult<Order>> CreateOrder(IFormCollection collection)
        {
            try
            {
                string CC = "6292400011276686";
                if (CC != "6292400011276686")
                {
                    ViewBag.Message = "Payment rejected with Credit Card No. you supplied";
                    return View("Payment");
                }
                string ODate = collection["CardExpiration"];
                /*string ODate = collection["CardExpiration"];*/
                int TotalAmount = 0;
                Random rnd = new Random();
                Order order = new Order
                {
                    CustomOrderNumber = Request.Cookies["userid"] + 78,
                    CustomerId = Int32.Parse(Request.Cookies["userid"]),
                    OrderGuid = Guid.Parse("69121893-3AFC-4F92-85F3-40BB5E7C7E29"),
                    StoreId = 1,
                    PickupInStore = false,
                    OrderStatusId = 1,
                    ShippingStatusId = 1,
                    PaymentStatusId = 1,
                    CurrencyRate = 1,
                    CustomerTaxDisplayTypeId = 1,
                    OrderSubtotalInclTax = TotalAmount,
                    OrderSubtotalExclTax = TotalAmount,
                    OrderSubTotalDiscountInclTax = 0,
                    OrderSubTotalDiscountExclTax = 0,
                    PaymentMethodAdditionalFeeInclTax = 0,
                    PaymentMethodAdditionalFeeExclTax = 0,
                    OrderTax = 0,
                    OrderDiscount = 0,
                    OrderTotal = TotalAmount,
                    RefundedAmount = 0,
                    CustomerLanguageId = 1,
                    AffiliateId = 0,
                    AllowStoringCreditCardNumber = false,
                    Deleted = false,
                    CardType = collection["CardType"],
                    CardName = collection["CardName"],
                    CardCvv2 = collection["CardCvv2"],
                    CardExpirationMonth = "1",
                    CardExpirationYear = "22",
                    CardNumber = collection["CardNumber"],
                    BillingAddressId = 1106,
                    CreatedOnUtc = DateTime.UtcNow
                };
                var client = new HttpClient();
                client.DefaultRequestHeaders.Clear();
                /*client.BaseAddress = new Uri("https://localhost:44356/api/Orders/PostOrder");*/
                client.BaseAddress = new Uri("https://localhost:44340/api/Orders/PostOrder");
                string data = JsonConvert.SerializeObject(order);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage Res = await client.PostAsync(client.BaseAddress, content);
                var Order = Res.Content.ReadAsStringAsync().Result;
                var a = JsonConvert.DeserializeObject<Order>(Order);

                if (HttpContext.Session.GetString("cart") != null)
                {
                    var value = HttpContext.Session.GetString("cart");
                    List<Cart> li = JsonConvert.DeserializeObject<List<Cart>>(value);
                    int i = li.Count();
                    for (var j = 0; j <= i - 1; j++)
                    {
                        var price = li[j].Price;
                        var name = li[j].Name;
                        var PID = li[j].Id;
                        var clientA = new HttpClient();
                        //Load order items of the vendor
                        UriBuilder builderA = new UriBuilder("https://localhost:44340/api/Attribute/GetProductAttribute?");
                        builderA.Query = "ProductId=" + PID;
                        HttpResponseMessage Aresponse = await clientA.GetAsync(builderA.Uri);
                        var ProductAttributes = Aresponse.Content.ReadAsStringAsync().Result;
                        var productattribute = JsonConvert.DeserializeObject<ProductAttribute[]>(ProductAttributes);
                        /*Added by Mohtashim on 07032022*/
                        /*Create Product Attributes XML*/
                        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(productattribute.GetType());
                        OrderItem orderItem = new OrderItem
                        {
                            OrderId = a.Id,
                            ProductId = li[j].Id,
                            OrderItemGuid = Guid.Parse("69121893-3AFC-4F92-85F3-40BB5E7C7E29"),
                            Quantity = 1,
                            UnitPriceInclTax = li[j].Price,
                            UnitPriceExclTax = li[j].Price,
                            AttributesXml = x.ToString(),
                            PriceInclTax = li[j].Price,
                            PriceExclTax = li[j].Price,
                            DiscountAmountInclTax = 0,
                            DiscountAmountExclTax = 0,
                            OriginalProductCost = 0,
                            DownloadCount = 0,
                            IsDownloadActivated = false,
                        };
                        var client1 = new HttpClient();
                        client1.DefaultRequestHeaders.Clear();
                        /*client1.BaseAddress = new Uri("https://localhost:44340/api/OrderItems/PostOrderItem");*/
                        client1.BaseAddress = new Uri("https://localhost:44340/api/OrderItems/PostOrderItem");

                        data = JsonConvert.SerializeObject(orderItem);
                        content = new StringContent(data, Encoding.UTF8, "application/json");
                        Res = await client1.PostAsync(client1.BaseAddress, content);
                        var OrderItem = Res.Content.ReadAsStringAsync().Result;
                    };

                    /*PostOrderItem*/



                    /*collection["exampleInputEmail1"]*/


                }
                ViewBag.Message = "You order has been placed. You will get confirmation email soon";
                return View("Payment");
            }
            catch (Exception e)
            {
                ViewBag.Message = "Error occured during transaction! Please try again";
                return View("Payment");
            }
        }

    }
}
