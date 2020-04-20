using Microsoft.AspNetCore.Mvc;

namespace app_mvc_core.Areas.Carrinho.Controllers
{
    public class CarrinhoController : Controller
    {
        [Area("Carrinho")]
        public ActionResult Index()
        {
            return View();
        }
    }
}