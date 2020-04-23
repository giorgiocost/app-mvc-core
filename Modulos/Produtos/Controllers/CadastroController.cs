using Microsoft.AspNetCore.Mvc;

namespace app_mvc_core.Modulos.Produtos.Controllers
{
    [Area("Produtos")]
    [Route("produtos")]
    public class CadastroController : Controller
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