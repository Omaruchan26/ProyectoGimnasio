using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryGym.Entidades
{
	public class Horarios
	{
		public int Id { get; set; }
		public int DiaSemana { get; set; }
		public TimeSpan HoraInicio { get; set; }
		public TimeSpan HoraFin { get; set; }
		public String? TipoActividad { get; set; }
		public bool Turno { get; set; }
		[NotMapped] public List<ClasesGrupales>? ClasesGrupales { get; set; }


	}
}
