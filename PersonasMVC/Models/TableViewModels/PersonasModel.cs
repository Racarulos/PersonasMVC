using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonasMVC.Models.TableViewModels
{
    public class PersonasModel
    {
		public int? Id { get; set; }
		public string Nombres { get; set; }
		public string Apellidos { get; set; }
		public DateTime? FechaNacimiento { get; set; }
		public int? idEstadoCivil { get; set; }
		public int? idGradoAcademico { get; set; }
		public string Direccion { get; set; }

	}
}