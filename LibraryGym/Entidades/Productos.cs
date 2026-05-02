

using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryGym.Entidades
{
	public class Productos
	{
		public int Id { get; set; }
		public String? Nombre { get; set; }
		public Decimal PrecioUnidad { get; set; }
		public String? Categoria { get; set; }
		public bool Disponible { get; set; }
		[NotMapped] public List<Inventarios>? Inventarios { get; set; }
		[NotMapped] public List<ComprasProductos>? ComprasProductos { get; set; }
	}
}
