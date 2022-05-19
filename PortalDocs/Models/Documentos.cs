namespace PortalDocs.Models
{
    /// <summary>
    /// Classe para instaciar lista de Documentos
    /// </summary>
    public class Documentos
    {
        /// <summary>
        /// Identificador Documentos
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Documentos requeridos do Parceiro
        /// </summary>
        public string DocumentoRequerido { get; set; }
        /// <summary>
        /// Tipo do Documento Requerido
        /// </summary>
        public string TipoDocumento { get; set; }


    }
}
