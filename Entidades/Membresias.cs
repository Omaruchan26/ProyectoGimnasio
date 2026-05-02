using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryGym.Entidades
{
	public class Membresias
	{
		public int Id { get; set; }
		public DateTime FechaInicio { get; set; }
		public bool Estado { get; set; }
		public int DuracionMeses { get; set; }
		public int TipoMembresia { get; set; }
		public int Cliente { get; set; }
		public int SubtipoMembresia { get; set; }

		[ForeignKey("TipoMembresia")] public TiposMembresias? _TipoMembresia { get; set; }
		[ForeignKey("SubtipoMembresia")] public SubtiposMembresias? _SubtipoMembresia { get; set; }
		[ForeignKey("Cliente")] public Clientes? _Cliente { get; set; }
		[NotMapped] public List<Pagos>? Pagos { get; set; }

	}
}
