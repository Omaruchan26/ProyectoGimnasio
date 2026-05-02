using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryGym.Entidades
{
	public class Entrenadores
	{
		public int Id { get; set; }
		public bool Certificacion { get; set; }
		public DateTime FechaIngres0 { get; set; }
		public int AñosExperiencia { get; set; }
		public Decimal Salario { get; set; }
		public bool Activo { get; set; }
		public int Persona { get; set; }
		[ForeignKey("Persona")] public Personas? _Persona { get; set; }
		[NotMapped] public List<ClasesGrupales>? ClasesGrupales { get; set; }

	}
}
