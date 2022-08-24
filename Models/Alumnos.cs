using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EV02.Models
{
    public partial class Alumnos
    {
        public Alumnos()
        {
            Notas = new HashSet<Notas>();
        }

        public string Codalu { get; set; }
        public string Nomalu { get; set; }
        public string Codcar { get; set; }
        public DateTime? Fecnac { get; set; }
        public string Eliminado { get; set; }

        public virtual Carreras CodcarNavigation { get; set; }
        public virtual ICollection<Notas> Notas { get; set; }
    }
}
