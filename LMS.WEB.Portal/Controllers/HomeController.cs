using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LMS.WEB.Portal.Models;
using Microsoft.AspNetCore.Http;

namespace LMS.WEB.Portal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
                return View();
        }
    }
}
