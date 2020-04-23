using Microsoft.AspNetCore.Mvc;

namespace app_mvc_core.Modulos.Cliente.Controllers
{
    [Area("Cliente")]
    [Route("clientes")]
    public class ClienteController : Controller
    {
        [Route("listar")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("buscar")]
        public IActionResult Buscar()
        {
            return View();
        }
    }
}