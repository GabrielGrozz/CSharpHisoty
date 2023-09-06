using System.ComponentModel.DataAnnotations;

namespace LOGIN_SYSTEM.Models
{
    public class LoginViewModel
    {
        //essa sera a nossa model para os dados do usuário

        [Required(ErrorMessage = "informe um nome")]
        [Display(Name = "Nome do usuário")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "informe uma senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha do usuário")]
        public string Password { get; set; }
        
        //a returnurl é a url da ultima página que abrimos
        public string ReturnUrl { get; set; }
    }
}
