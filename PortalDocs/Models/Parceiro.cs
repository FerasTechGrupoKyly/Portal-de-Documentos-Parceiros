using System.ComponentModel.DataAnnotations;

namespace PortalDocs.Models
{
    public class Parceiro
    {
        public int Id { get; set; }
        [Required]
        public string DocumentosEmpresa { get; set; }
        [Required]
        public string NomeFuncionario { get; set; }
        [Required]
        public string CpfFuncionario { get; set; }
        [Required]
        public string RgFuncionario { get; set; }
        [Required]
        public string DocumentosFuncionario { get; set; }

    }
}
