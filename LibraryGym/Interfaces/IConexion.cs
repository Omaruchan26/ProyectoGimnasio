using LibraryGym.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace LibraryGym.Interfaces
{
	public interface IConexion
	{
		string? StringConexion { get; set; }

		DbSet<Personas>? Personas { get; set; }
        DbSet<Administrativos>? Administrativos { get; set; }

        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}