using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortalDocs.Models
{
    /// <summary>
    /// Classe para instanciar lista de Funcionários
    /// </summary>
    public class Funcionarios
    {
        /// <summary>
        /// Identificador Funcionário
        /// </summary>
        [Required]
        public int Id { get; set; }
        /// <summary>
        /// Documento CPF do Funcionário
        /// </summary>
        [Required]
        public string CPF { get; set; }
        /// <summary>
        /// String nome do Funcionário
        /// </summary>
        [Required]
        public string Nome { get; set; }
        /// <summary>
        /// Documento RG do Funcionário
        /// </summary>
        [Required]
        public string Rg { get; set; }
      }
}