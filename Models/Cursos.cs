using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EV02.Models
{
    public partial class Cursos
    {
        public Cursos()
        {
            Notas = new HashSet<Notas>();
        }

        public string Codcur { get; set; }
        public string Nomcur { get; set; }
        public int? Nhoras { get; set; }
        public string Eliminado { get; set; }

        public virtual ICollection<Notas> Notas { get; set; }
    }
}
