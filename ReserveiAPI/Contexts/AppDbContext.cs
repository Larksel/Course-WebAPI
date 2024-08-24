using Microsoft.EntityFrameworkCore;
using ReserveiAPI.Contexts.Builders;
using ReserveiAPI.Objects.Models.Entities;

namespace ReserveiAPI.Contexts
{
    public class AppDbContext : DbContext
    {
        // Mapeamento Relacional dos Objetos no Banco de Dados
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Conjunto: Usuário
        public DbSet<UserModel> Users { get; set; }

        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Entidades de usuário
            UserBuilder.Build(modelBuilder);
        }
    }
}
