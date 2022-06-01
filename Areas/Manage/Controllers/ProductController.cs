using Ap103PartialView.DAL;
using Ap103PartialView.Extensions;
using Ap103PartialView.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Ap103PartialView.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public ProductController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {

            List<Product> products = _context.Products.Include(p=>p.ProductCategories).ThenInclude(pc=>pc.Category).ToList();
            return View(products);
        }
        public IActionResult Create()
        {
            ViewBag.Categories=_context.Categories.ToList();
            ViewBag.Tags=_context.Tags.ToList();

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Tags=_context.Tags.ToList();

            if (!ModelState.IsValid) return View();
            if (product.PhotoFile != null)
            {
                if (!product.PhotoFile.IsImage())
                {
                    ModelState.AddModelError("PhotoFile", "Sekil formati duzgun deyil");
                    return View();
                }
                if (!product.PhotoFile.IsSizeOk(5))
                {
                    ModelState.AddModelError("PhotoFile", "Max 5mb ola biler");
                    return View();
                }
                product.Image = product.PhotoFile.SaveImg(_env.WebRootPath, "img");
            }
            else
            {
                ModelState.AddModelError("PhotoFile", "Sekil elave edin");
                return View();
            }
           
            product.ProductCategories = new List<ProductCategory>();
            if (product.CategoryIds != null)
            {
                foreach (var categoryId in product.CategoryIds)
                {
                    ProductCategory pCategory = new ProductCategory
                    {
                        Product=product,
                        CategoryId=categoryId
                    };
                    _context.ProductCategories.Add(pCategory);
                }
            }

            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
