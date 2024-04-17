using Investify.Models;
using Microsoft.EntityFrameworkCore;

namespace Investify.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<IdeiaModel> Ideia { get; set; }
        public DbSet<CarteiraModel> Carteira { get; set; }
        public DbSet<GeneroModel> Genero { get; set; }
        public DbSet<CargoModel> Cargo { get; set; }
    }
}
