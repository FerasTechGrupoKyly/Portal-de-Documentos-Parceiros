namespace PortalDocs.Models
{
    /// <summary>
    /// Classe que instancia lista de documentos do Parceiro
    /// </summary>
    public class DocumentosParceiro
    {
        /// <summary>
        /// Identificador da tabela DocumentosParceiro
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Documentos da Empresa Parceira
        /// </summary>
        public string DocumentosEmpresa { get; set; }
        /// <summary>
        /// Documentos necessários dos Funcionarios
        /// </summary>
        public string DocumentosFuncionarios { get; set; }
    }
}
