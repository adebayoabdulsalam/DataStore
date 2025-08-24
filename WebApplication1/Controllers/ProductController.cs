using WebApplication1.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private readonly AplicationDbContext context;
        public ProductController(AplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var Products = context.Products.OrderByDescending(p => p.Id).ToList();
            return View(Products);
        }
    }
}