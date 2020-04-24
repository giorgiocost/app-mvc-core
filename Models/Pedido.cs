using System;

namespace app_mvc_core.Models
{
    public class Pedido
    {
        public Guid Id { get; set; }

        Pedido()
        {
            Id = Guid.NewGuid();
        }
     
    }
}