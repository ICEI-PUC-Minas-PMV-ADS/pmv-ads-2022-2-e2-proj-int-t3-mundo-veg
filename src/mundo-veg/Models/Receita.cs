using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace mundo_veg.Models
{
    [Table("Receitas")]
    public class Receita
    {
        [Key]
        public int Id { get; set; }

        [StringLength(40, MinimumLength = 2, ErrorMessage = "Este campo precisa ter entre 2 e 40 caracteres!")]
        [Required(ErrorMessage = "É necessário informar o nome!")]
        public string? Nome { get; set; }

        [StringLength(500, MinimumLength = 10, ErrorMessage = "Este campo precisa ter entre 10 e 500 caracteres!")]
        [Required(ErrorMessage = "É necessário informar os ingredientes!")]
        public string? Ingredientes { get; set; }

        [Display(Name = "Modo de preparo")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Este campo precisa ter entre 10 e 1000 caracteres!")]
        [Required(ErrorMessage = "É necessário informar o modo de preparo!")]
        public string? Modo_Preparo { get; set; }

        [Display(Name = "Rendimento (porções)")]
        [Required(ErrorMessage = "É necessário informar o rendimento!")]
        public int Rendimento { get; set; }

        [Display(Name = "Dificuldade no preparo")]
        [Required(ErrorMessage = "É necessário informar a dificuldade!")]
        public Dificuldade Dificuldade { get; set; }

        [Display(Name = "Tempo de preparo (minutos)")]
        [Required(ErrorMessage = "É necessário informar o tempo de preparo!")]
        public int Tempo_Preparo { get; set; }

        [Required(ErrorMessage = "É necessário informar a categoria!")]
        public Categoria Categoria { get; set; }

        public string? Imagem { get; set; }

        [ForeignKey("UsuarioPf")]
        public int ClienteId { get; set; }

        public UsuarioPf? Cliente { get; set; }

    }

    public enum Dificuldade
    {
        Fácil,
        Média,
        Difícil
    }

}
