using Assignment_03_Library.DataAccess;
using Assignment_03_Library.Repositories;
using Assignment_03_WebApp.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Assignment_03_WebApp.Controllers
{
    public class CartController : Controller
    {
        private Member AdminAccount()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            Member admin = new Member
            {
                MemberId = 0,
                Email = config["AdminAccount:Email"],
                City = "",
                CompanyName = "",
                Country = "",
                Password = config["AdminAccount:Password"]
            };
            return admin;
        }
        IOrderDetailRepository orderDetailRepository = null;
        IOrderRepository orderRepository = null;
        IProductRepository productRepository = null;
        public CartController()
        {
            orderDetailRepository = new OrderDetailRepository();
            orderRepository = new OrderRepository();
            productRepository = new ProductRepository();
        }

        private int isExisting(int id, List<OrderDetail> cart)
        {
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].ProductId == id)
                {
                    return i;
                }
            }
            return -1;
        }
        // GET: CartController
        public ActionResult Index()
        {
            List<OrderDetail> card = HttpContext.Session.GetObjectFromJson<List<OrderDetail>>("Card");
            Member mem = HttpContext.Session.GetObjectFromJson<Member>("Member");
            if (card == null)
            {
                HttpContext.Session.Remove("Card");
                HttpContext.Session.SetObjectAsJson("Card", card);
            }
            return View();
        }
        public ActionResult AddCard(int? id)
        {
            List<OrderDetail> card = HttpContext.Session.GetObjectFromJson<List<OrderDetail>>("Card");
            if (card == null)
            {
                card = new List<OrderDetail>();
                if (id != null)
                {
                    var pro = productRepository.GetProductById(id.Value);
                    if (pro != null)
                    {
                        card.Add(new OrderDetail
                        {
                            OrderId = orderRepository.GetNextId(),
                            ProductId = pro.ProductId,
                            Discount = 0,
                            Quantity = 1,
                            UnitPrice = pro.UnitPrice
                        });
                    }
                }
            }
            else
            {
                if (id != null)
                {
                    var pro = productRepository.GetProductById(id.Value);
                    int index = isExisting(id.Value, card);
                    if (index == -1)
                    {
                        if (index == -1)
                        {
                            card.Add(new OrderDetail
                            {
                                OrderId = orderRepository.GetNextId(),
                                ProductId = pro.ProductId,
                                Discount = 0,
                                Quantity = 1,
                                UnitPrice = pro.UnitPrice
                            });
                        }
                        else
                        {
                            card.Add(new OrderDetail
                            {
                                OrderId = card[0].OrderId,
                                ProductId = pro.ProductId,
                                Discount = 0,
                                Quantity = 1,
                                UnitPrice = pro.UnitPrice
                            });
                        }
                    }
                    else
                    {
                        card[index].Quantity = card[index].Quantity + 1;
                    }
                }
            }
            HttpContext.Session.SetObjectAsJson("Card", card);
            return RedirectToAction(nameof(Index));
        }
        // GET: CartController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CartController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CartController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: CartController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CartController/Edit/5
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

        // GET: CartController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CartController/Delete/5
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
        public ActionResult Remove(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                List<OrderDetail> card = HttpContext.Session.GetObjectFromJson<List<OrderDetail>>("Card");
                int index = isExisting(id.Value, card);
                if (index != -1)
                {
                    card[index].Quantity = card[index].Quantity - 1;
                    if (card[index].Quantity == 0)
                    {
                        card.Remove(card[index]);
                    }
                }
                else
                {
                    return NotFound();
                }
                HttpContext.Session.SetObjectAsJson("Card", card);
            }
            return RedirectToAction(nameof(Index));
        }
        public ActionResult RemoveAll(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                List<OrderDetail> card = HttpContext.Session.GetObjectFromJson<List<OrderDetail>>("Card");
                int index = isExisting(id.Value, card);
                if (index != -1)
                {
                    card.Remove(card[index]);
                }
                else
                {
                    return NotFound();
                }
                HttpContext.Session.SetObjectAsJson("Card", card);
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Save(string orderId, string quantity)
        {
            if (!string.IsNullOrEmpty(quantity) && !string.IsNullOrEmpty(orderId))
            {
                int quan = int.Parse(quantity);
                int id = int.Parse(orderId);
                List<OrderDetail> card = HttpContext.Session.GetObjectFromJson<List<OrderDetail>>("Card");
                int index = isExisting(id, card);
                if (index != -1)
                {
                    card[index].Quantity = quan;
                }
                else
                {
                    return NotFound();
                }
                HttpContext.Session.SetObjectAsJson("Card", card);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Buy()
        {
            List<OrderDetail> card = HttpContext.Session.GetObjectFromJson<List<OrderDetail>>("Card");
            Member mem = HttpContext.Session.GetObjectFromJson<Member>("Member");
            orderRepository = new OrderRepository();
            int orderId = orderRepository.GetNextId();
            Order order = new Order
            {
                Freight = 0,
                MemberId = mem.MemberId,
                OrderDate = DateTime.Now,
                RequiredDate = DateTime.Now,
                ShippedDate = DateTime.Now,
                OrderId = orderId,
            };
            orderRepository.AddOrder(order);
            orderDetailRepository = new OrderDetailRepository();
            foreach (var item in card)
            {
                item.OrderId = orderId;
                orderDetailRepository.Add(item);
            }

            HttpContext.Session.Remove("Card");

            List<Product> proList = null;
            if (mem == null)
            {
                return View("/Views/Members/Login.cshtml");
            }
            proList = productRepository.GetProducts();
            return View("/Views/Products/Index.cshtml", proList);
        }
    }
}
