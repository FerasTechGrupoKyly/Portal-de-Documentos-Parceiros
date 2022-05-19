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


        /// <summary>
        /// Configurando Db
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

          => optionsBuilder.UseSqlite(connectionString: "DataSource=Solicitacao.db;Cache=Shared");

    }
}
