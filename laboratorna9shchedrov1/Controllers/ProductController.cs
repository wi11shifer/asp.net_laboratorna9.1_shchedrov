using laboratorna9shchedrov1.Models;
using Microsoft.AspNetCore.Mvc;

namespace laboratorna9shchedrov1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
        {
            new Product { ID = 1, Name = "Apple", Price = 100 },
            new Product { ID = 2, Name = "Banana", Price = 200 },
            new Product { ID = 3, Name = "Cherry", Price = 300 }
        };

            return View(products);

        }
    }
}