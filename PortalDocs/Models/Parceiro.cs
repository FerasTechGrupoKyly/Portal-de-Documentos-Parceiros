using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortalDocs.Models
{
    /// <summary>
    /// Classe para instanciar Lista de Parceiro
    /// </summary>
    public class Parceiro
    {
        /// <summary>
        /// Identificador do Parceiro
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Documento CNPJ do Parceiro
        /// </summary>
        public string CNPJ { get; set; }
        /// <summary>
        /// String nome do Parceiro
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// string endereço Email do Parceiro
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Lista de Funcionários do Parceiro
        /// </summary>
        public List<Funcionarios> Funcionarios { get; set; }
        /// <summary>
        /// Documentos requeridos do parceiro
        /// </summary>
        public List<DocumentosParceiro> Documentos { get; set; }
        
     }
}