using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryGym.Entidades
{
	public class Equipos
	{
		public int Id { get; set; }
		public bool Estado { get; set; }
		public string? Nombre { get; set; }
		public string? Marca { get; set; }
		public DateTime FechaCompra { get; set; }
		public int VidaUtil { get; set; }
		public int Sede { get; set; }

		[ForeignKey("Sede")] public Sedes? _Sede { get; set; }
		[NotMapped] public List<MantenimientoEquipos>? MantenimientoEquipos { get; set; }


	}
}
