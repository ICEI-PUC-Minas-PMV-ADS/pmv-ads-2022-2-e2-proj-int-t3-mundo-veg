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

        [StringLength(40, MinimumLength = 4, ErrorMessage = "Este campo precisa ter entre 4 e 40 caracteres!")]
        [Required(ErrorMessage = "É necessário informar o nome!")]
        public string? Nome { get; set; }

        [Display(Name = "E-mail")]
        [StringLength(40, MinimumLength = 4, ErrorMessage = "Este campo precisa ter entre 8 e 40 caracteres!")]
        [EmailAddress(ErrorMessage = "Este não é um formato válido de e-mail!")]
        [Required(ErrorMessage = "É necessário informar o e-mail!")]
        public string? Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3,4})[-. ]?([0-9]{4})$", ErrorMessage = "Este não é um número válido de telefone")]
        [Required(ErrorMessage = "É necessário informar o telefone!")]
        public string? Telefone { get; set; }

        [StringLength(20, MinimumLength = 1, ErrorMessage = "Este campo precisa ter entre 1 e 20 caracteres!")]
        [Required(ErrorMessage = "É necessário informar a rua da sua residência!")]
        public string? Rua { get; set; }

        [Display(Name = "Número")]
        [StringLength(6, MinimumLength = 1, ErrorMessage = "Este campo precisa ter entre 1 e 6 caracteres!")]
        [Required(ErrorMessage = "É necessário informar o número da sua residência!")]
        public string? Numero { get; set; }

        [StringLength(20, MinimumLength = 1, ErrorMessage = "Este campo precisa ter entre 1 e 20 caracteres!")]
        [Required(ErrorMessage = "É necessário informar o bairro da sua residência!")]
        public string? Bairro { get; set; }

        [StringLength(20, MinimumLength = 2, ErrorMessage = "Este campo precisa ter entre 2 e 20 caracteres!")]
        [Required(ErrorMessage = "É necessário informar a cidade da sua residência!")]
        public string? Cidade { get; set; }

        [Required(ErrorMessage = "É necessário informar o estado da sua residência!")]
        public Estado Estado { get; set; }

        [MaxLength(8), MinLength(8, ErrorMessage = "Este campo precisa ter 8 caracteres!")]
        [Required(ErrorMessage = "É necessário informar o CEP da sua residência!")]
        public int? CEP { get; set; }

        [Required(ErrorMessage = "É necessário informar a categoria!")]
        public Categoria Categoria { get; set; }

        [StringLength(8, MinimumLength = 8, ErrorMessage = "Este campo precisa ter 8 caracteres!")]
        [Required(ErrorMessage = "É necessário informar a senha!")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }
    }
}
