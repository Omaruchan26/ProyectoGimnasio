

using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryGym.Entidades
{
	public class TiposSubtipos
	{
		public int Id { get; set; }
		public int IdTipoMembresia { get; set; }
		public Decimal Descuento { get; set; }
		public int TipoMembresia { get; set; }
		public int SubtipoMembresia { get; set; }
		[ForeignKey("SubTipo")] public SubtiposMembresias? _SubtipoMembresia { get; set; }
		[ForeignKey("TipoMembresia")] public TiposMembresias? _TipoMembresia { get; set; }
	}
}
