using Investify.Models;
using Microsoft.EntityFrameworkCore;

namespace Investify.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Teste> Testes { get; set; }
    }
}
