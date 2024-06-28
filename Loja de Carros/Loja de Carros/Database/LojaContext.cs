using Microsoft.EntityFrameworkCore;
using Loja_de_Carros.Models;

namespace Loja_de_Carros.Database;

public class LojaContext : DbContext
{
    public DbSet<Veiculo> Veiculos { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionStr = "server=localhost;database=loja_DB;user=root;password=admin;";
            optionsBuilder.UseMySql(connectionStr, ServerVersion.AutoDetect(connectionStr));
        }
    }
}