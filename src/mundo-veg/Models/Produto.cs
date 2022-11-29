using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mundo_veg.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [StringLength(40, MinimumLength = 2, ErrorMessage = "Este campo precisa ter entre 2 e 40 caracteres!")]
        [Required(ErrorMessage = "É necessário informar o nome!")]
        public string? Nome { get; set; }

        [Display(Name = "Quantidade (unidades)")]
        [Required(ErrorMessage = "É necessário informar a quantidade!")]
        public int? Quantidade { get; set; }

        [Display(Name = "Descrição)")]
        [Required(ErrorMessage = "É necessário informar a descrição do produto!")]
        [StringLength(100, MinimumLength = 15, ErrorMessage = "Este campo precisa ter no mínimo 15 caracteres!")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "É necessário informar o preço!")]
        [Display(Name = "Preço (R$)")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Escreva no formato R$00,00!")]
        public string? Preco { get; set; }

        [Required(ErrorMessage = "É necessário informar a categoria!")]
        public Categoria Categoria { get; set; }

        [MaxLength(300)]
        public string? Imagem { get; set; }

        [ForeignKey("UsuarioPj")]
        public int EstabelecimentoId { get; set; }
        public UsuarioPj? Estabelecimento { get; set; }
    }
}
