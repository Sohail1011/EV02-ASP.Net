using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EV02.Models
{
    public partial class Proveedores
    {
        public Proveedores()
        {
            Productos = new HashSet<Productos>();
        }

        public int IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string NombreContacto { get; set; }
        public string CargoContacto { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Region { get; set; }
        public string CodPostal { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string PaginaPrincipal { get; set; }

        public virtual ICollection<Productos> Productos { get; set; }
    }
}
