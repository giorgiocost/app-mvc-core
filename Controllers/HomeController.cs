using Microsoft.AspNetCore.Mvc;

namespace app_mvc_core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}