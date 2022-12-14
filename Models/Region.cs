using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EV02.Models
{
    public partial class Region
    {
        public Region()
        {
            Territorios = new HashSet<Territorios>();
        }

        public int IdRegion { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Territorios> Territorios { get; set; }
    }
}
