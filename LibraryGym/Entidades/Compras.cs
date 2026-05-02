
using System.ComponentModel.DataAnnotations.Schema;


namespace LibraryGym.Entidades
{
	public class Compras
	{
		public int Id { get; set; }
		public DateTime FechaCompra { get; set; }
		public decimal Total { get; set; }
		public int Cliente { get; set; }

		[ForeignKey("Cliente")] public Clientes? _Cliente { get; set; }
		[NotMapped] public List<ComprasProductos>? ComprasProductos { get; set; }
		[NotMapped] public List<Pagos>? Pagos { get; set; }
	}
}
