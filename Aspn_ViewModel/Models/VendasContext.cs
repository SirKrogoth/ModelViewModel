using Microsoft.EntityFrameworkCore;
using Aspn_ViewModel.ViewModel;
using ModelViewViewModel.Model;

namespace ModelViewViewModel.Models
{
    public class VendasContext : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=(local);" +
                              "Initial Catalog=Vendas;Integrated Security=True;Pooling=False");
        }

        public DbSet<Aspn_ViewModel.ViewModel.ClienteViewModel> ClienteViewModel { get; set; }
    }
}