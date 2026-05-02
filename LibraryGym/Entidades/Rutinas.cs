using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryGym.Entidades
{
	public class Rutinas
	{
		public int IdRutina { get; set; }
		public String? Nombre { get; set; }
		public String? Objetivo { get; set; }
		public DateTime FechaAsignacion { get; set; }
		public bool Estado { get; set; }
		public int Cliente { get; set; }

		[ForeignKey("Cliente")] public Clientes? _Cliente { get; set; }
	}
}
