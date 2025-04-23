using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Listing_ClickImoveis.Models
{
    [Table("Midia")]
    public class Midia
    {
        [Key]
        public int Id { get; set; }

        // URL da imagem ou vídeo
        [Required]
        public string Url { get; set; } = string.Empty;

        // Tipo da mídia (imagem, vídeo)
        [Required]
        public string Tipo { get; set; } = string.Empty;

        // Chave estrangeira para a tabela Listing
        [ForeignKey("Listing")]
        public int ListingId { get; set; }

        // Relacionamento com o anúncio
        public Listing Listing { get; set; }
    }
}
