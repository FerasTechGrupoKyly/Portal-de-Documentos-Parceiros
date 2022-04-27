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
        public string ParceiroNome { get; set; }
        [Required]
        public string ParceiroEmail { get; set; }
        [Required]
        public string ParceiroCnpj { get; set; }
        [Required]
        public string DocumentoRequerido { get; set; }
        [Required]
        public string TipoDocumento { get; set; }
    }
}
