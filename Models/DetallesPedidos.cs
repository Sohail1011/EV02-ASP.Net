using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EV02.Models
{
    public partial class DetallesPedidos
    {
        public int IdPedido { get; set; }
        public int IdProducto { get; set; }
        public decimal PrecioUnidad { get; set; }
        public int Cantidad { get; set; }
        public decimal Descuento { get; set; }
        public string Eliminado { get; set; }

        public virtual Pedidos IdPedidoNavigation { get; set; }
        public virtual Productos IdProductoNavigation { get; set; }
    }
}
