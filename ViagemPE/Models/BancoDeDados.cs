using Microsoft.EntityFrameworkCore;

namespace ViagemPE.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }    
        public DbSet<Destino> Destinos { get; set; }    
        public DbSet<Promo> Promocoes { get; set; }    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=ViagemPE; Integrated Security=True");
        }
    }
}
