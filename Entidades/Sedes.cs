

using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryGym.Entidades
{
	public class Sedes
	{
		public int Id { get; set; }
		public String? Nombre { get; set; }
		public String? Ciudad { get; set; }
		public String? Direccion { get; set; }
		public int CapacidadMaxima { get; set; }
		public String? Telefono { get; set; }
		[NotMapped] public List<Equipos>? Equipos { get; set; }
		[NotMapped] public List<SalonesSedes>? SalonesSedes { get; set; }
		[NotMapped] public List<Administrativos>? Administrativos { get; set; }
		[NotMapped] public List<ControlAccesos>? ControlAccesos { get; set; }
	}
}
