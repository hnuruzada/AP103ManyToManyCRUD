using Ap103PartialView.DAL;
using Ap103PartialView.Models;
using Ap103PartialView.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ap103PartialView.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {
            List<Category> categories=_context.Categories.Where(c=>c.ProductCategories.Any(pc=>pc.ProductId==id)).ToList();
            HomeVM hvm = new HomeVM
            {
                DataCategory=categories,
                Products=_context.Products.ToList(),
                Categories=_context.Categories.ToList()
            };
            
            return View(hvm);
        }

        
    }
}
