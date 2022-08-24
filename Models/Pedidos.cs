using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EV02.Models
{
    public partial class Pedidos
    {
        public Pedidos()
        {
            DetallesPedidos = new HashSet<DetallesPedidos>();
        }

        public int IdPedido { get; set; }
        public string IdCliente { get; set; }
        public int? IdEmpleado { get; set; }
        public DateTime? FechaPedido { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public int? FormaEnvio { get; set; }
        public decimal? Cargo { get; set; }
        public string Destinatario { get; set; }
        public string DireccionDestinatario { get; set; }
        public string CiudadDestinatario { get; set; }
        public string RegionDestinatario { get; set; }
        public string CodPostalDestinatario { get; set; }
        public string PaisDestinatario { get; set; }
        public string Eliminado { get; set; }

        public virtual Clientes IdClienteNavigation { get; set; }
        public virtual Empleados IdEmpleadoNavigation { get; set; }
        public virtual ICollection<DetallesPedidos> DetallesPedidos { get; set; }
    }
}
