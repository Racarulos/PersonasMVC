﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PersonasEntities : DbContext
    {
        public PersonasEntities()
            : base("name=PersonasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GradoAcademico> GradoAcademico { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<InfoPersonas> InfoPersonas { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivil { get; set; }
    }
}
