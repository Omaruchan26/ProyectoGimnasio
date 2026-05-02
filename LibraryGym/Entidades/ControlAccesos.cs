
using System.ComponentModel.DataAnnotations.Schema;


namespace LibraryGym.Entidades
{
	public class ControlAccesos
	{
		public int Id { get; set; }
		public DateTime FechaEntrada { get; set; }
		public DateTime FechaSalida { get; set; }
		public int Persona { get; set; }
		public int Sede { get; set; }

		[ForeignKey("Persona")] public Personas? _Persona { get; set; }
		[ForeignKey("Sede")] public Sedes? _Sede { get; set; }

	}
}
