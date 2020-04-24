using app_mvc_core.Models;

namespace app_mvc_core.Data
{
    public class PedidosRepository : IPedidosRepository
    {
        public Pedidos ObterPedido()
        {
            return new Pedidos();
        }
    }

    public interface IPedidosRepository
    {
        Pedidos ObterPedido();
    }
}