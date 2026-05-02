
using System.ComponentModel.DataAnnotations.Schema;


namespace LibraryGym.Entidades
{
	public class ComprasProductos
	{
		public int Id { get; set; }
		public Decimal SubTotal { get; set; }
		public int Cantidad { get; set; }
		public int Compra { get; set; }
		public int Producto { get; set; }

		[ForeignKey("Compra")] public Compras? _Compra { get; set; }
		[ForeignKey("Producto")] public Productos? _Producto { get; set; }

	}
}
