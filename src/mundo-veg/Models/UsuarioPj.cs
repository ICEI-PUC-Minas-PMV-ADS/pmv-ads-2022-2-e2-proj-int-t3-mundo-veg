using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mundo_veg.Models
{
    [Table("usuarios_pessoa_juridica")]

    public class UsuarioPj
    {
       

        [Key]
        public int Id { get; set; }

        [StringLength(18, MinimumLength = 18, ErrorMessage = "Este campo precisa ter 18 caracteres!")]
        [Required(ErrorMessage = "É necessário informar o CNPJ!")]
        public string? CNPJ { get; set; }

        [StringLength(40, MinimumLength = 2, ErrorMessage = "Este campo precisa ter entre 2 e 40 caracteres!")]
        [Required(ErrorMessage = "É necessário informar o nome do estabelecimento!")]
        public string? Nome { get; set; }

        [Display(Name = "E-mail")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Este campo precisa ter entre 8 e 30 caracteres!")]
        [EmailAddress(ErrorMessage = "Este não é um formato válido!")]
        [Required(ErrorMessage = "É necessário informar o e-mail!")]
        public string? Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{4,5})[-. ]?([0-9]{4})$", ErrorMessage = "Digite seu telefone no formato (XXX)XXXX-XXXX")]
        [Required(ErrorMessage = "É necessário informar o telefone!")]
        public string? Telefone { get; set; }

        [StringLength(20, MinimumLength = 1, ErrorMessage = "Este campo precisa ter entre 1 e 20 caracteres!")]
        [Required(ErrorMessage = "É necessário informar a rua do estabelecimento!")]
        public string? Rua { get; set; }

        [Display(Name = "Número")]
        [StringLength(6, MinimumLength = 1, ErrorMessage = "Este campo precisa ter entre 1 e 6 caracteres!")]
        [Required(ErrorMessage = "É necessário informar o número do estabelecimento!")]
        public string? Numero { get; set; }

        [StringLength(20, MinimumLength = 1, ErrorMessage = "Este campo precisa ter entre 1 e 20 caracteres!")]
        [Required(ErrorMessage = "É necessário informar o bairro do estabelecimento!")]
        public string? Bairro { get; set; }

        [StringLength(20, MinimumLength = 2, ErrorMessage = "Este campo precisa ter entre 2 e 20 caracteres!")]
        [Required(ErrorMessage = "É necessário informar a cidade do estabelecimento!")]
        public string? Cidade { get; set; }

        [Required(ErrorMessage = "É necessário informar o estado do estabelecimento!")]
        public Estado Estado { get; set; }

        [Required(ErrorMessage = "É necessário informar o CEP do estabelecimento!")]
       // [StringLength(10,MinimumLength = 10, ErrorMessage = "Escreva no formato XX.XXX-XXX!")]
        public string? CEP { get; set; }

        [Display(Name = "Horário de funcionamento")]
        [StringLength(20, MinimumLength = 7, ErrorMessage = "Este campo precisa ter entre 7 e 20 caracteres!")]
        [Required(ErrorMessage = "É necessário informar o horário de funcionamento do estabelecimento!")]
        public string? Horario_funcionamento { get; set; }

        [Display(Name = "Delivery")]
        [Required(ErrorMessage = "É necessário informar se faz entrega!")]
        public bool? Faz_entrega { get; set; }

        [Display(Name = "Tempo de entrega (minutos)")]
        [MaxLength(2), MinLength(1, ErrorMessage = "Este campo precisa ter entre 1 ou 2 caracteres!")]
        public string? Tempo_entrega { get; set; }

        [Display(Name = "Descrição")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Este campo precisa ter entre 4 e 100 caracteres!")]
        [Required(ErrorMessage = "É necessário informar a descrição!")]
        public string? Descricao { get; set; }

        [Display(Name = "Contato (WhatsApp)")]
        [StringLength(27, MinimumLength = 27, ErrorMessage = "Este campo precisa ter 27 caracteres!")]
        [Required(ErrorMessage = "É necessário informar o número do Whatsapp!")]
        public string? Contato { get; set; }

        [Required(ErrorMessage = "É necessário informar a senha!")]
        //[StringLength(15, MinimumLength = 8, ErrorMessage = "Este campo precisa ter entre 8 e 15 caracteres!")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }

        [MaxLength(300)]
        public string? Imagem { get; set; }

        public List<Produto>? Produtos { get; set; }
    }
}


