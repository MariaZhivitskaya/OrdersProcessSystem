using System.Net.Http;
using System.Web.Mvc;
using System.Web.Security;
using BLL.Interfaces;
using OrderProcessWeb.ViewModels;

namespace OrderProcessWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;

        public HomeController(IUserService uService, IRoleService rService)
        {
            _userService = uService;
            _roleService = rService;
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

        [HttpPost]
        public ActionResult GetRole(int roleId)
        {
            var role = _roleService.GetRole(roleId);

            return Json(new {StringContent = role.Description});
        }

        [HttpPost]
        public ActionResult GetCurrentUserRole()
        {
            MembershipUser membershipUser = Membership.GetUser();
            if (membershipUser == null)
                return Json(new { CurrentUserRole = "" });

            string login = membershipUser.UserName;
           
            var user = _userService.GetUserByLogin(login);
            var role = _roleService.GetRole(user.RoleId);

            return Json(new { CurrentUserRole = role.Description });
        }
    }
}
