using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EV02.Models
{
    public partial class Territorios
    {
        public Territorios()
        {
            EmpleadosTerritorios = new HashSet<EmpleadosTerritorios>();
        }

        public string IdTerritorio { get; set; }
        public string Descripcion { get; set; }
        public int IdRegion { get; set; }

        public virtual Region IdRegionNavigation { get; set; }
        public virtual ICollection<EmpleadosTerritorios> EmpleadosTerritorios { get; set; }
    }
}
