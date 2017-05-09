using System.ComponentModel.DataAnnotations;

namespace OrderProcessWeb.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "Login")]
        [Required(ErrorMessage = "Please, enter your login")]
        public string Login { get; set; }

        [Display(Name = "Enter your password")]
        [Required(ErrorMessage = "Please, enter your password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}