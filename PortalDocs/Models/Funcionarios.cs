using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortalDocs.Models
{
    public class Funcionarios
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Rg { get; set; }
    }
}