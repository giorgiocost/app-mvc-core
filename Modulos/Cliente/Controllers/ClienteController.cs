using Microsoft.AspNetCore.Mvc;

namespace app_mvc_core.Modulos.Cliente.Controllers
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