using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryGym.Entidades
{
	public class MantenimientoEquipos
	{
		public int Id { get; set; }
		public DateTime FechaMantenimiento { get; set; }
		public string? Descripcion { get; set; }
		public decimal Costo { get; set; }
		public int Equipo { get; set; }

		[ForeignKey("Equipo")] public Equipos? _Equipo { get; set; }
	}
}
