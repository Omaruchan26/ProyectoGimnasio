using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryGym.Entidades
{
	public class SalonesSedes
	{
		public int Id { get; set; }
		public String? Nombre { get; set; }
		public int Capacidad { get; set; }
		public String? TipoSalon { get; set; }
		public int Piso { get; set; }
		public bool Estado { get; set; }
		public int Sede { get; set; }

		[ForeignKey("Sede")]  public Sedes? _Sede { get; set; }
		[NotMapped] public List<ClasesGrupales>? ClasesGrupales { get; set; }

	}
}
