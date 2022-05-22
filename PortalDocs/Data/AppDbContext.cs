using Microsoft.EntityFrameworkCore;
using PortalDocs.Models;

namespace PortalDocs.Data
{
    /// <summary>
    /// Classe que herda de DbContext responsavel por configurar o Banco de Dados
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Tabela de Solicitação do Banco de dados 
        /// </summary>
        public DbSet<Solicitacao> Solicitacoes { get; set; }
        /// <summary>
        /// Tabela de Parceiro do Banco de dados 
        /// </summary>
        public DbSet<Parceiro> Parceiros { get; set; }
        /// <summary>
        /// Tabela de DocumentoSolicitação do Banco de dados 
        /// </summary>
        public DbSet<DocumentoSolicitacao> DocumentoSolicitacoes { get; set; }
        /// <summary>
        /// Tabela de DocumentoParceiro do Banco de dados 
        /// </summary>
        public DbSet<DocumentosParceiro> DocumentosParceiros { get; set; }
        /// <summary>
        /// Tabela de Funcionarios do Banco de dados 
        /// </summary>
        public DbSet<Funcionarios> Funcionarios { get; set; }





        /// <summary>
        /// Configuração do Banco de dados e da String de conexão
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

          => optionsBuilder.UseSqlite(connectionString: "DataSource=Solicitacao.db;Cache=Shared");

    }
}
