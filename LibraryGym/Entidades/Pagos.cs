using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryGym.Entidades
{
	public class Pagos
	{
		public int Id { get; set; }
		public Decimal Valor { get; set; }
		public DateTime FechaPago { get; set; }
		public bool Aprobado { get; set; }
		public String? Observaciones { get; set; }
		public int Membresia { get; set; }
		public int TipoPago { get; set; }
		public int Compra { get; set; }

		[ForeignKey("Membresia")] public Membresias? _Membresia { get; set; }
		[ForeignKey("TipoPago")] public TiposPagos? _TipoPago { get; set; }
		[ForeignKey("Compra")] public Compras? _Compra { get; set; }
		[NotMapped] public List<Facturas>? Facturas { get; set; }
	}
}
