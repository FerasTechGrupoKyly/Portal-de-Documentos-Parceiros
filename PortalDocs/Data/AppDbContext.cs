using Microsoft.EntityFrameworkCore;
using PortalDocs.Models;

namespace PortalDocs.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Solicitacao> Solicitacoes { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
          =>  optionsBuilder.UseSqlite(connectionString: "DataSource=Solicitacao.db;Cache=Shared");
        
    }
}
