
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LibraryGym.Entidades
{
	public class Administrativos
	{
		[Key] public int Id { get; set; }
		public DateTime FechaInicio { get; set; }
		public DateTime FechaSalida { get; set; }
		public Decimal Salario { get; set; }
		public String? Cargo { get; set; }
		public bool Estado { get; set; }
		public int Sede { get; set; }
		public int Persona { get; set; }

		[ForeignKey("Sede")] public Sedes? _Sede { get; set; }
		[ForeignKey("Persona")] public Personas? _Persona { get; set; }
	}
}
