using Microsoft.AspNetCore.Mvc;

namespace app_mvc_core.Modulos.Produtos.Controllers
{
    public class CadastroController : Controller
    {
        [Area("Produtos")]
        public IActionResult Index()
        {
            return View();
        }
    }
}