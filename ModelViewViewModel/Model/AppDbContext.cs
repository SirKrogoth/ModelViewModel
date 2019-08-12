using Microsoft.EntityFrameworkCore;

namespace ModelViewViewModel.Model
{
    public class AppDbContext : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=(local);" +
                              "Initial Catalog=Vendas;Integrated Security=True;Pooling=False");
        }
    }
}