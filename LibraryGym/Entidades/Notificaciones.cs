

using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryGym.Entidades
{
	public class Notificaciones
	{
		public int Id { get; set; }
		public String? Mensaje { get; set; }
		public DateTime? FechaEnvio { get; set; }
		public bool Leida { get; set; }
		public int Usuario { get; set; }

		[ForeignKey("Usuario")] public Usuarios? _Usuario { get; set; }
	}
}
