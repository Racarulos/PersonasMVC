using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PersonasMVC.Models.TableModels
	// Aqui se creo los modelos para ingresar y editar los registros
{
    public class IngresoPersonasModel
    {

		[Required]
		[Display(Name ="Nombres")]
		[StringLength(100,ErrorMessage = "Es muy largo los nombres", MinimumLength = 5)]
		public string Nombres { get; set; }
		[Required]
		[Display(Name = "Apellidos")]
		[StringLength(100, ErrorMessage = "Es muy largo los apellidos", MinimumLength = 5)]
		public string Apellidos { get; set; }
		[Required]
		[Display(Name = "Fecha de hacimiento")]
		[DataType(DataType.Date)]
		public DateTime? FechaNacimiento { get; set; }
		[Required]
		[Display(Name = "Estado civil")]
		public int? idEstadoCivil { get; set; }
		[Required]
		[Display(Name = "Grado academico")]
		public int? idGradoAcademico { get; set; }
		[Required]
		[Display(Name = "Dirección")]
		public string Direccion { get; set; }


	}
	public class EditarPersonasModel
	{

		public int id { get; set; }

		[Required]
		[Display(Name = "Nombres")]
		[StringLength(100, ErrorMessage = "Es muy largo los nombres", MinimumLength = 5)]
		public string Nombres { get; set; }
		[Required]
		[Display(Name = "Apellidos")]
		[StringLength(100, ErrorMessage = "Es muy largo los apellidos", MinimumLength = 5)]
		public string Apellidos { get; set; }
		[Required]
		[Display(Name = "Fecha de hacimiento")]
		[DataType(DataType.Date)]
		public DateTime? FechaNacimiento { get; set; }
		[Required]
		[Display(Name = "Estado civil")]
		public int? idEstadoCivil { get; set; }
		[Required]
		[Display(Name = "Grado academico")]
		public int? idGradoAcademico { get; set; }
		[Required]
		[Display(Name = "Dirección")]
		public string Direccion { get; set; }


	}
}