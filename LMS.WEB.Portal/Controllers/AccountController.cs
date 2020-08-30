using System.Threading.Tasks;
using AutoMapper;
using LMS.WEB.Portal.Mappers;
using LMS.WEB.Portal.Models;
using LMS.WEB.Portal.OBModels;
using LMS.WEB.Portal.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS.WEB.Portal.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILoginRepository _loginRepository;
        public AccountController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        // GET: Account
        public ActionResult LogIn()
        {
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }
        [HttpPost]
        public async Task<ActionResult> LogIn(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                LoginViewModel loginView = _loginRepository.GetLoggedInUser(model.UserName, model.Password);
                if (loginView == null)
                {
                    ModelState.AddModelError("Password", "Invalid login attempt.");
                    return View("LogIn");
                }
                HttpContext.Session.SetString("userId", loginView.UserName);
                return RedirectToAction("Index", loginView.Role);
            }
            else
            {
                return View("LogIn");
            }
        }
    }
}