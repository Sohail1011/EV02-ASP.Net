using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EV02.Models
{
    public partial class Productos
    {
        public Productos()
        {
            DetallesPedidos = new HashSet<DetallesPedidos>();
        }

        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int? IdProveedor { get; set; }
        public int? IdCategoria { get; set; }
        public string CantidadPorUnidad { get; set; }
        public decimal? PrecioUnidad { get; set; }
        public short? UnidadesEnExistencia { get; set; }
        public short? UnidadesEnPedido { get; set; }
        public short? NivelNuevoPedido { get; set; }
        public bool Suspendido { get; set; }

        public virtual Categorias IdCategoriaNavigation { get; set; }
        public virtual Proveedores IdProveedorNavigation { get; set; }
        public virtual ICollection<DetallesPedidos> DetallesPedidos { get; set; }
    }
}
