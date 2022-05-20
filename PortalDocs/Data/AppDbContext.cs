using Microsoft.EntityFrameworkCore;
using PortalDocs.Models;

namespace PortalDocs.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Solicitacao> Solicitacoes { get; set; }
        public DbSet<Parceiro> Parceiros { get; set; }
        public DbSet<DocumentoSolicitacao> DocumentoSolicitacoes { get; set; }
        public DbSet<DocumentosParceiro> DocumentosParceiros { get; set; }
        public DbSet<Funcionarios> Funcionarios { get; set; }






        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

          => optionsBuilder.UseSqlite(connectionString: "DataSource=Solicitacao.db;Cache=Shared");

    }
}
