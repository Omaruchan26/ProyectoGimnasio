
using System.ComponentModel.DataAnnotations.Schema;


namespace LibraryGym.Entidades
{
	public class Reportes
	{
		public int Id { get; set; }
		public string? Mensaje { get; set; }
		public DateTime FechaReporte { get; set; }
		public bool Estado { get; set; }
		public int Persona { get; set; }

		[ForeignKey("Persona")] public Clientes? _Persona { get; set; }
	}
}
