using Microsoft.AspNetCore.Mvc;

namespace WebsiteDotnet.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
