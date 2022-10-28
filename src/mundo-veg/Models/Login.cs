using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace mundo_veg.Models
{
    public class Login
    {
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "É necessário informar o e-mail!")]
        public string? Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "É necessário informar a senha!")]
        public string? Senha { get; set; }
    }
}
