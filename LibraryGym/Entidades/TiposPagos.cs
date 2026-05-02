

using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryGym.Entidades
{
	public class TiposPagos
	{
		public int Id { get; set; }
		public String? Nombre { get; set; }
		public bool DigitalEfewctivo { get; set; }
		public bool TieneComision { get; set; }
		public bool Disponible { get; set; }
		[NotMapped] public List<Pagos>? Pagos { get; set; }

	}
}
