using Microsoft.EntityFrameworkCore;
using PortalDocs.Models;

namespace PortalDocs.Data
{
    /// <summary>
    /// Banco de Dados
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Banco de dados das solicitações
        /// </summary>
        public DbSet<Solicitacao> Solicitacoes { get; set; }
        public DbSet<Parceiro> Parceiros { get; set; }
        public DbSet<DocumentoSolicitacao> DocumentoSolicitacoes { get; set; }
        public DbSet<DocumentosParceiro> DocumentosParceiros { get; set; }
        public DbSet<Funcionarios> Funcionarios { get; set; }





        /// <summary>
        /// Configurando Db
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

          => optionsBuilder.UseSqlite(connectionString: "DataSource=Solicitacao.db;Cache=Shared");

    }
}
