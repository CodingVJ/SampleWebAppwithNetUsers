using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SampleWebAppwithNetUsers.Models;

namespace SampleWebAppwithNetUsers.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult NonSecureMethod()
        {
            return View();
        }
        [Authorize]
        public IActionResult SecureMethod()
        {
            return View();
        }
    }
}
