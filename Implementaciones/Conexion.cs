

using LibraryGym.Entidades;
using LibraryGym.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryGym.Implementaciones
{
	public class Conexion : DbContext, IConexion
    {
		public string? StringConexion { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(this.StringConexion!, p => { });
			optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
		}

		public DbSet<Personas>? Personas { get; set; }
        public DbSet<Administrativos>? Administrativos { get; set; }
    }
}
