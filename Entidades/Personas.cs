
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryGym.Entidades
{
	public class Personas
	{
		public int Id { get; set; }
		public String? Nombre { get; set; }
		public String? Apellido { get; set; }
		public String? Documento { get; set; }
		public String? Telefono { get; set; }
		public String? Correo { get; set; }
		public String? Direccion { get; set; }
		public DateTime FechaNacimiento { get; set; }
		[NotMapped] public List<Administrativos>? Administrativos { get; set; }
		[NotMapped] public List<Clientes>? Clientes { get; set; }
		[NotMapped] public List<Entrenadores>? Entrenadores { get; set; }
		[NotMapped] public List<Reportes>? Reportes { get; set; }
		[NotMapped] public List<ControlAccesos>? ControlAccesos { get; set; }
		[NotMapped] public List<Usuarios>? Usuarios { get; set; }

	}
}
