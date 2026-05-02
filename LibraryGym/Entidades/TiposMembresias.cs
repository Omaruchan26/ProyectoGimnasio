
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryGym.Entidades
{
	public class TiposMembresias
	{
		public int Id { get; set; }
		public String? Nombre { get; set; }
		public Decimal Precio { get; set; }
		public String? Descripcion { get; set; }
		[NotMapped] public List<Membresias>? Membresias { get; set; }
		[NotMapped] public List<TiposSubtipos>? TiposSubtipos { get; set; }
	}
}
