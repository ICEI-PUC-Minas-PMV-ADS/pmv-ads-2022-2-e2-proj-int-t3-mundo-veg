using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mundo_veg.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "É necessário informar o nome!")]
        public string? Nome { get; set; }
    
        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "É necessário informar a quantidade!")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "É necessário informar a descrição do produto!")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "É necessário informar o preço!")]
        [Display(Name = "Preço (R$)")]
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
