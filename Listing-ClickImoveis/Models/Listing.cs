using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Listing_ClickImoveis.Models
{
    [Table("Listing")]
    public class Listing
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Título é obrigatório.")]
        public string Título { get; set; }

        [Required(ErrorMessage = "A Descrição é obrigatória.")]
        public string Descrição { get; set; }

        [Required(ErrorMessage = "O Endereço é obrigatório.")]
        public string Endereço { get; set; }

        [Required(ErrorMessage = "A Cidade é obrigatória.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O Estado é obrigatório.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório.")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O Preço é obrigatório.")]
        public decimal Preço { get; set; }

        // Data de criação do anúncio
        [Display(Name = "Data de criação")]
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        // Data da última atualização do anúncio
        [Display(Name = "Data da última atualização")]
        public DateTime? DataUltimaAtualizacao { get; set; }

        // Status do anúncio (Ativo/Inativo)
        public bool Ativo { get; set; } = true;

        // Categoria do anúncio (Imóvel, Carro, Produto, etc.)
        public string Categoria { get; set; }

        // Tipo do anúncio (Venda ou Aluguel, por exemplo, se for imóvel)
        [Display(Name = "Tipo de anúncio")]
        public string TipoAnuncio { get; set; }

        // Imagens/Vídeos relacionados ao anúncio
        public List<Midia> Midias { get; set; } = new();

        // Para imóveis, adicionar a área
        public double? Area { get; set; } // Área em metros quadrados, se aplicável
    }
}

