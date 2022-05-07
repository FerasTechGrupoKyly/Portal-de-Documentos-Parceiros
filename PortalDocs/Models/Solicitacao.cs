using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortalDocs.Models
{
    public class Solicitacao
    {
        public int Id { get; set; }
        [Required]
        public string ObservacaoSolicitacao { get; set; }
        [Required]
        public string Solicitante { get; set; }
        [Required]
        public string Data { get; set; }
        [Required]
        public List<Parceiro> Parceiro { get; set;} 
        [Required]
        public List<Documentos> Documentos { get; set; }

    }
    
}
