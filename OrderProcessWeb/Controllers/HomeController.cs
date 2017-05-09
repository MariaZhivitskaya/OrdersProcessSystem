using System.Web.Mvc;
using System.Web.Security;
using BLL.Interfaces;
using OrderProcessWeb.ViewModels;

namespace OrderProcessWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController(IUserService uService)
        {
            _userService = uService;
        }


        public ActionResult Index() => View();

        public ActionResult Home()
        {
            string login = Membership.GetUser().UserName;
            var user = _userService.GetUserByLogin(login);

            var model = new UserViewModel
            {
                Id = user.Id,
                Login = user.Login,
                Surname = user.Surname,
                Name = user.Name,
                RoleId = user.RoleId
            };

            return View(model);
        }

        [HttpGet]
        public JsonResult GetRole(int roleId)
        {
            return Json("sdfsdf");
        }
    }
}
