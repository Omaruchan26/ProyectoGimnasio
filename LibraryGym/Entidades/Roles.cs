
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryGym.Entidades
{
	public class Roles
	{
		public int Id { get; set; }
		public String? Nombre { get; set; }
		public String? Descripcion { get; set; }
		[NotMapped] public List<Usuarios>? Usuarios { get; set; }
	}
}
