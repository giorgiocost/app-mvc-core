using Microsoft.AspNetCore.Mvc;

namespace app_mvc_core.Modulos.Carrinho.Controllers
{
    [Area("Carrinho")]
    [Route("carrinho")]
    public class CarrinhoController : Controller
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