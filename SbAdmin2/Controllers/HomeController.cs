using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SbAdmin2.Models;
using System.Diagnostics;

namespace SbAdmin2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return GetAuthenticatedView();
        }

        public IActionResult Buttons()
        {
            return GetAuthenticatedView();
        }

        public IActionResult Cards()
        {
            return GetAuthenticatedView();
        }

        public IActionResult UtilitiesColor()
        {
            return GetAuthenticatedView();
        }

        public IActionResult UtilitiesBorders()
        {
            return GetAuthenticatedView();
        }

        public IActionResult UtilitiesAnimation()
        {
            return GetAuthenticatedView();
        }

        public IActionResult UtilitiesOther()
        {
            return GetAuthenticatedView();
        }

        public IActionResult PageNotFound()
        {
            return GetAuthenticatedView();
        }

        public IActionResult Blank()
        {
            return GetAuthenticatedView();
        }

        public IActionResult Charts()
        {
            return GetAuthenticatedView();
        }

        public IActionResult Tables()
        {
            return GetAuthenticatedView();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private IActionResult GetAuthenticatedView()
        {
            if (User.Identity?.IsAuthenticated == false)
            {
                return Redirect("/Identity/Account/Login");
            }
            return View();
        }
    }
}