using System.ComponentModel.DataAnnotations;

namespace OrderProcessWeb.ViewModels
{
    public class RegisterViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "Login")]
        [Required(ErrorMessage = "Please, enter a login")]
        [StringLength(100, ErrorMessage = "Login must contain at least {2} characters", MinimumLength = 6)]
        public string Login { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please, enter your password")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password must contain at least {2} characters", MinimumLength = 6)]
        public string Password { get; set; }

        [Display(Name = "Confirm password")]
        [Required(ErrorMessage = "Confirm password!")]
        [Compare("Password", ErrorMessage = "Passwords are different!")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Surname")]
        [Required(ErrorMessage = "Please, enter your surname")]
        public string Surname { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please, enter your name")]
        public string Name { get; set; }
    }
}