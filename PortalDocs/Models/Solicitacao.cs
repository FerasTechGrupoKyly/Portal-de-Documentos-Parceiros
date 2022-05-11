using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortalDocs.Models
{
    /// <summary>
    /// Dados dos Documentos Solicitados
    /// </summary>
    public class Solicitacao 
    {
        /// <summary>
        /// Código identificador da solicitação
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Campo para preenchimento das Observações da Solicitação
        /// </summary>
        [Required]
        public string ObservacaoSolicitacao { get; set; }
        /// <summary>
        /// Nome do solicitante
        /// </summary>
        [Required]
        public string Solicitante { get; set; }

        [Required]
        public string Data { get; set; }
        /// <summary>
        /// Nome do Parceiro
        /// </summary>
        [Required]
        public List<Parceiro> Parceiro { get; set;} 
        /// <summary>
        /// Informar os documentos do parceiro.
        /// </summary>
        [Required]
        public List<Documentos> Documentos { get; set; }

    }
    
}
