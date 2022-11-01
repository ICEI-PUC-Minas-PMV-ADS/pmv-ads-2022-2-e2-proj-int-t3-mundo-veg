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

        [Required(ErrorMessage = "É necessário informar o nome!")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "É necessário informar os ingredientes!")]
        public string? Ingredientes { get; set; }

        [Display(Name = "Modo de preparo")]
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
    }

    public enum Dificuldade
    {
        Fácil,
        Média,
        Difícil
    }

}
