using System.ComponentModel.DataAnnotations;

namespace OrderProcessWeb.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "Login")]
        [Required(ErrorMessage = "Please, enter your login")]
        //[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Invalid email!")]
        public string Login { get; set; }

        [Display(Name = "Enter your password")]
        [Required(ErrorMessage = "Please, enter your password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}