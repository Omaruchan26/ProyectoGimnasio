
using System.ComponentModel.DataAnnotations.Schema;


namespace LibraryGym.Entidades
{
	public class Reservas
	{
		public int Id { get; set; }
		public DateTime FechaReserva { get; set; }
		public bool Estado { get; set; }
		public int ClaseGrupal { get; set; }

		[ForeignKey("ClaseGrupal")] public ClasesGrupales? _ClaseGrupal { get; set; }
	}
}
