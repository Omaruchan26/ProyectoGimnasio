

using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryGym.Entidades
{
	public class Clientes
	{
		public int Id { get; set; }
		public DateTime FechaRegistro { get; set; }
		public bool Activo { get; set; }
		public int Persona { get; set; }
		[ForeignKey("Persona")] public Personas? _Persona { get; set; }
		[NotMapped] public List<Compras>? Compras { get; set; }
		[NotMapped] public List<EvaluacionesFisicas>? EvaluacionesFisicas { get; set; }
		[NotMapped] public List<Membresias>? Membresias { get; set; }
		[NotMapped] public List<Rutinas>? Rutinas { get; set; }

	}
}
