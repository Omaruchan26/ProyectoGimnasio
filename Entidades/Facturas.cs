using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryGym.Entidades
{
	public class Facturas
	{
		public int Id { get; set; }
		public String? CodigoFactura { get; set; }
		public DateTime FechaEmision { get; set; }
		public Decimal Subtotal { get; set; }
		public Decimal Impuestos { get; set; }
		public Decimal Total { get; set; }
		public int Pago { get; set; }

		[ForeignKey("Pago")] public Pagos? _Pago { get; set; }
	}
}
