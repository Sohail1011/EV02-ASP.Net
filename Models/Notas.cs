using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EV02.Models
{
    public partial class Notas
    {
        public string Codalu { get; set; }
        public string Codcur { get; set; }
        public int? Pract { get; set; }
        public int? Trab { get; set; }
        public int? Examen { get; set; }
        public DateTime? Fecreg { get; set; }
        public string Eliminado { get; set; }

        public virtual Alumnos CodaluNavigation { get; set; }
        public virtual Cursos CodcurNavigation { get; set; }
    }
}
