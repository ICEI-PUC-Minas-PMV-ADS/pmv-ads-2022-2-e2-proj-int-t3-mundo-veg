using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mundo_veg.Models
{
    [Table("usuarios_pessoa_juridica")]

    public class UsuarioPj
    {
       

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "É necessário informar o CNPJ!")]
        public string? CNPJ { get; set; }

        [Required(ErrorMessage = "É necessário informar o nome do estabelecimento!")]
        public string? Nome { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "É necessário informar o e-mail!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "É necessário informar o telefone!")]
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "É necessário informar a rua do estabelecimento!")]
        public string? Rua { get; set; }

        [Display(Name = "Número")]
        [Required(ErrorMessage = "É necessário informar o número do estabelecimento!")]
        public string? Numero { get; set; }

        [Required(ErrorMessage = "É necessário informar o bairro do estabelecimento!")]
        public string? Bairro { get; set; }

        [Required(ErrorMessage = "É necessário informar a cidade do estabelecimento!")]
        public string? Cidade { get; set; }

        [Required(ErrorMessage = "É necessário informar o estado do estabelecimento!")]
        public Estado Estado { get; set; }

        [Required(ErrorMessage = "É necessário informar o CEP do estabelecimento!")]
        public string? CEP { get; set; }

        [Display(Name = "Horário de funcionamento")]
        [Required(ErrorMessage = "É necessário informar o horário de funcionamento do estabelecimento!")]
        public string? Horario_funcionamento { get; set; }

        [Display(Name = "Faz entrega")]
        [Required(ErrorMessage = "É necessário informar se faz entrega!")]
        public bool? Faz_entrega { get; set; }

        [Display(Name = "Tempo de entrega (minutos)")]
        public string? Tempo_entrega { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "É necessário informar a descrição!")]
        public string? Descricao { get; set; }

        [Display(Name = "Contato (WhatsApp)")]
        [Required(ErrorMessage = "É necessário informar o número do Whatsapp!")]
        public string? Contato { get; set; }

        [Required(ErrorMessage = "É necessário informar a senha!")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }
    }
}


