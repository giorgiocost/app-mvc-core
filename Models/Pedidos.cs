using System;

namespace app_mvc_core.Models
{
    public class Pedidos
    {
        public Guid Id { get; set; }

        public Pedidos()
        {
            Id = Guid.NewGuid();
        }
     
    }
}