using Business.Abstracts;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class LoginController : Controller
    {
        IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost("login")]
        public ActionResult Index(User user)
        {
            var result = _userService.Login(user);
            if (result.Success)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            return View(result.Message);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost("UsAdd")]
        public IActionResult Add(User user)
        {
            var result = _userService.Add(user);
            if (result.Success)
            {
                return Redirect("Login/Add");
            }
            return View(result);
        }
    }
}
