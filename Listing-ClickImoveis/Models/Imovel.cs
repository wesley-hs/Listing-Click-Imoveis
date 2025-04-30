using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Listing_ClickImoveis.Models
{
    [Table("Imovel")]
    public class Imovel
    {
        [Key]
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Descricao { get; set; }

        public string? Tipo { get; set; }

        public string? Endereco { get; set; }

        public string? Cidade { get; set; }

        public string? Estado { get; set; }

        public float? Preco { get; set; }

        public string? Imagem { get; set; }

    }
}
