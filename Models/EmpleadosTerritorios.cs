using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EV02.Models
{
    public partial class EmpleadosTerritorios
    {
        public int IdEmpleado { get; set; }
        public string IdTerritorio { get; set; }

        public virtual Empleados IdEmpleadoNavigation { get; set; }
        public virtual Territorios IdTerritorioNavigation { get; set; }
    }
}
