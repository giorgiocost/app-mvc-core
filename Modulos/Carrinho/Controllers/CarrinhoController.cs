using Microsoft.AspNetCore.Mvc;

namespace app_mvc_core.Modulos.Carrinho.Controllers
{
    public class CarrinhoController : Controller
    {
        [Area("Carrinho")]
        public IActionResult Index()
        {
            return View();
        }
    }
}