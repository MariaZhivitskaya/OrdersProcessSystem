using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using BLL.Interfaces;
using OrderProcessWeb.Providers;
using OrderProcessWeb.ViewModels;

namespace OrderProcessWeb.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        private readonly IUserService userService;

        public LoginController(IUserService userService)
        {
            this.userService = userService;
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            //var type = HttpContext.User.GetType();
            //var iden = HttpContext.User.Identity.GetType();
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel viewModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(viewModel.Login, viewModel.Password))
                {
                    //var user = userService.GetUserByLogin(viewModel.Login);

                    FormsAuthentication.SetAuthCookie(viewModel.Login, true);
                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid login or password!");
            }
            return View(viewModel);
        }

        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Register() => View();

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register(RegisterViewModel viewModel)
        {
            var anyUser = userService.GetAllUsers().Any(u => u.Login.Contains(viewModel.Login));

            if (anyUser)
            {
                ModelState.AddModelError("", "Such email already registered!");
                return View(viewModel);
            }

            if (ModelState.IsValid)
            {
                var membershipUser = ((CustomMembershipProvider)Membership.Provider)
                    .CreateUser(viewModel.Login, viewModel.Password, viewModel.Surname,
                    viewModel.Name);

                if (membershipUser != null)
                {
                    FormsAuthentication.SetAuthCookie(viewModel.Login, false);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Sorry, an error occured while registration...");
            }
            return View(viewModel);
        }

        [ChildActionOnly]
        public ActionResult LoginPartial() =>
            PartialView("_Login");
    }
}