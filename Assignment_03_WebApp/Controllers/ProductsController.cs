using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assignment_03_Library.DataAccess;
using Assignment_03_Library.Repositories;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using System.Collections.Generic;
using Assignment_03_WebApp.Helpers;

namespace Assignment_03_WebApp.Controllers
{
    public class ProductsController : Controller
    {
        IProductRepository productRepository = null;
        public ProductsController()
        {
            productRepository = new ProductRepository();
        }
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

        // GET: ProductsController
        public ActionResult Index()
        {
            List<Product> proList = null;
            Member mem = HttpContext.Session.GetObjectFromJson<Member>("Member");
            if (mem == null)
            {
                return View("/Views/Members/Login.cshtml");
            }
            proList = productRepository.GetProducts();
            return View(proList);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var pro = productRepository.GetProductById(id.Value);
            if (pro == null)
            {
                return NotFound();
            }
            return View(pro);
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            Member mem = HttpContext.Session.GetObjectFromJson<Member>("Member");
            if (mem == null)
            {
                return View("Login");
            }
            else if (mem.Email != AdminAccount().Email)
            {
                ViewBag.PopUp = "You cannot access this function!!!!";
                return View("/Views/Home/Index.cshtml");
            }
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product pro)
        {
            try
            {
                if (pro.UnitInStock < 0)
                {
                    ViewBag.Message = "Unit In Stock must be greater than 0";
                    return View();
                }
                else if (pro.UnitPrice < 0)
                {
                    ViewBag.Message = "Unit In Stock must be greater than 0";
                    return View();
                }
                else
                {
                    if (ModelState.IsValid)
                    {
                        productRepository.AddProduct(pro);
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int? id)
        {
            Member mem = HttpContext.Session.GetObjectFromJson<Member>("Member");
            if (mem == null)
            {
                return View("/Views/Members/Login.cshtml");
            }
            else if (id == null)
            {
                return NotFound();
            }
            var pro = productRepository.GetProductById(id.Value);
            if (pro == null)
            {
                return NotFound();
            }
            return View(pro);
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product pro)
        {
            try
            {
                if (id != pro.ProductId)
                {
                    return NotFound();
                }
                if (pro.UnitInStock < 0)
                {
                    ViewBag.Message = "Unit In Stock must be greater than 0";
                    return View();
                }
                else
                {
                    if (ModelState.IsValid)
                    {
                        productRepository.UpdateProduct(pro);
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }
                productRepository.DeleteProduct(id.Value);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
