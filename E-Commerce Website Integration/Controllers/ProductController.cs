using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Website_Integration.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
