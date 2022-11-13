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

        [StringLength(500, MinimumLength = 10, ErrorMessage = "Este campo precisa ter entre 10 e 500 caracteres!")]
        [Required(ErrorMessage = "É necessário informar os ingredientes!")]
        public string? Ingredientes { get; set; }

        [Required(ErrorMessage = "É necessário informar o preço!")]
        [Display(Name = "Preço (R$)")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Este campo precisa ter entre 3 e 10 caracteres!")]
        public string? Preco { get; set; }

        [Required(ErrorMessage = "É necessário informar a categoria!")]
        public Categoria Categoria { get; set; }
    }
}
