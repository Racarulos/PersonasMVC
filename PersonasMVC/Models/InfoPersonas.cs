//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonasMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InfoPersonas
    {
        public int idPersona { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public Nullable<int> idEstadoCivil { get; set; }
        public Nullable<int> idGradoAcademico { get; set; }
        public string Direccion { get; set; }
    
        public virtual GradoAcademico GradoAcademico { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
    }
}