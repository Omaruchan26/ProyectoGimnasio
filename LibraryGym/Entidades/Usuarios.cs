

using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryGym.Entidades
{
	public class Usuarios
	{
		public int Id { get; set; }
		public DateTime FechaCreacion { get; set; }
		public String? UserName { get; set; }
		public String? Password { get; set; }
		public bool Estado { get; set; }
		public int Rol { get; set; }
		public int Persona { get; set; }

		[ForeignKey("Rol")] public Roles? _Rol { get; set; }
		[ForeignKey("Persona")] public Personas? _Persona { get; set; }
		[NotMapped] public List<Notificaciones>? Notificaciones { get; set; }
	}
}
