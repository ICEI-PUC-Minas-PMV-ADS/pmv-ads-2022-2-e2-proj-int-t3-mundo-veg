using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mundo_veg.Models
{
    [Table("Usuários: Pessoa Física")]
    public class UsuarioPf
    {
        [Key]
        public int Id { get; set; }

        [StringLength(11, MinimumLength = 11, ErrorMessage = "Este campo precisa ter 11 caracteres!")]
        [Required(ErrorMessage = "É necessário informar o CPF!")]
        public string? CPF { get; set; }

      
        [Required(ErrorMessage = "É necessário informar o nome!")]
        public string? Nome { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Este não é um formato válido de e-mail!")]
        [Required(ErrorMessage = "É necessário informar o e-mail!")]
        public string? Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{4,5})[-. ]?([0-9]{4})$", ErrorMessage = "Digite seu telefone no formato (XX)XXXXX-XXXX")]
        [Required(ErrorMessage = "É necessário informar o telefone!")]
        public string? Telefone { get; set; }

        
        [Required(ErrorMessage = "É necessário informar a rua da sua residência!")]
        public string? Rua { get; set; }

        [Display(Name = "Número")]
      
        [Required(ErrorMessage = "É necessário informar o número da sua residência!")]
        public string? Numero { get; set; }

       
        [Required(ErrorMessage = "É necessário informar o bairro da sua residência!")]
        public string? Bairro { get; set; }

        
        [Required(ErrorMessage = "É necessário informar a cidade da sua residência!")]
        public string? Cidade { get; set; }

        [Required(ErrorMessage = "É necessário informar o estado da sua residência!")]
        public Estado Estado { get; set; }

        [Required(ErrorMessage = "É necessário informar o CEP da sua residência!")]
     
        public int? CEP { get; set; }

        [Required(ErrorMessage = "É necessário informar a categoria!")]
        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "É necessário informar a senha!")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }

        public List<Receita>? Receitas { get; set; }
    }
}
