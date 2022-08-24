using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EV02.Models
{
    public partial class Carreras
    {
        public Carreras()
        {
            Alumnos = new HashSet<Alumnos>();
        }

        public string Codcar { get; set; }
        public string Nomcar { get; set; }
        public string Eliminado { get; set; }

        public virtual ICollection<Alumnos> Alumnos { get; set; }
    }
}
