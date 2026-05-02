using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryGym.Entidades
{
	public class ClasesGrupales
	{
		public int Id { get; set; }
		public String? Nombre { get; set; }
		public int CupoMaximo { get; set; }
		public bool Estado { get; set; }
		public bool RequiereReserva { get; set; }
		public int DuracionMinutos { get; set; }
		public int Entrenador { get; set; }
		public int Horario { get; set; }
		public int SalonSede { get; set; }

		[ForeignKey("Entrenador")] public Entrenadores? _Entrenador { get; set; }
		[ForeignKey("Horario")] public Horarios? _Horario { get; set; }
		[ForeignKey("SalonSede")] public SalonesSedes? _SalonSede { get; set; }
		[NotMapped] public List<Reservas>? Reservas { get; set; }
	}
}
