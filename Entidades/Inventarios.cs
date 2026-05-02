using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryGym.Entidades
{
	public class Inventarios
	{
		public int Id { get; set; }
		public int StockActual { get; set; }
		public DateTime FechActulizacion { get; set; }
		public int Producto { get; set; }

		[ForeignKey("Producto")] public Productos? _Producto { get; set; }
	}
}
