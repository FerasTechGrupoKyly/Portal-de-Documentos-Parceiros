using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortalDocs.Models
{
    /// <summary>
    /// Classe que instancia Solicitacão do Parceiro 
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

        /// <summary>
        /// Data da Solicitação
        /// </summary>
        [Required]
        public string Data { get; set; }
        /// <summary>
        /// Lista de parceiro
        /// </summary>
        [Required]
        public List<Parceiro> Parceiro { get; set;} 
        /// <summary>
        /// Informar os documentos do parceiro.
        /// </summary>
        [Required]
        public List<DocumentoSolicitacao> Documentos { get; set; }

    }
    
}
