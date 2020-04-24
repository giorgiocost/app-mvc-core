using app_mvc_core.Data;
using Microsoft.AspNetCore.Mvc;

namespace app_mvc_core.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPedidosRepository _pedidosRepository;

        public HomeController(IPedidosRepository pedidosRepository)
        {
            _pedidosRepository = pedidosRepository;
        }
        public IActionResult Index()
        {            
            var pedidos = _pedidosRepository.ObterPedido();
            
            return View();
        }

        // quando não for possivel injectar direto no construtor
        public IActionResult ResolvendoLegado([FromServices] IPedidosRepository pedidosRepository)
        {
            var pedidos = _pedidosRepository.ObterPedido();
            
            return View();
        }
    }
}