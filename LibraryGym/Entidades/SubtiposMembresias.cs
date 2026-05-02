
using System.ComponentModel.DataAnnotations.Schema;


namespace LibraryGym.Entidades
{
	public class SubtiposMembresias
	{
		public int Id { get; set; }
		public String? Nombre { get; set; }
		[NotMapped] public List<TiposSubtipos>? TiposSubtipos { get; set; }
		[NotMapped] public List<Membresias>? Membresias { get; set; }

	}
}
