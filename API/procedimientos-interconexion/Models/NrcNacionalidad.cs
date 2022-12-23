using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class NrcNacionalidad
    {
        public decimal PaiCodigo { get; set; }
        public string PaiNacionalidad { get; set; }
        public string PaiDescripcion { get; set; }
        public string PaiUsuarioCreacion { get; set; }
        public DateTime PaiFechaCreacion { get; set; }
        public string PaiUsuarioModificacion { get; set; }
        public DateTime? PaiFechaModificacion { get; set; }
        public string PaiCveNacionalidad { get; set; }
    }
}
