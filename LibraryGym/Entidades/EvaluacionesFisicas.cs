using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryGym.Entidades
{
	public class EvaluacionesFisicas
	{
		public int Id { get; set; }
		public Decimal GrasaCorporal { get; set; }
		public DateTime FechaEvaluacion { get; set; }
		public Decimal Peso { get; set; }
		public String? Observaciones { get; set; }
		public int Cliente { get; set; }

		[ForeignKey("Cliente")] public Clientes? _Cliente { get; set; }
	}
}
