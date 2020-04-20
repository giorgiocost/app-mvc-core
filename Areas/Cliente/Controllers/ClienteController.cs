using Microsoft.AspNetCore.Mvc;

namespace app_mvc_core.Areas.Cliente.Controllers
{
    public class ClienteController : Controller
    {
        [Area("Cliente")]
        public IActionResult Index()
        {
            return View();
        }
    }
}