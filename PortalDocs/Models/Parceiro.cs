using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortalDocs.Models
{
    public class Parceiro
    {
        public int Id { get; set; }
        [Required]
        public string CNPJ { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public List<Funcionarios> Funcionarios { get; set; }
        [Required]
        public string DocumentosEmpresa  { get; set; }
        [Required]
        public string DocumentosFuncionario { get; set; }

    }
}