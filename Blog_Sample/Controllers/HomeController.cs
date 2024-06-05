using Blog_Sample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blog_Sample.Controllers
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
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [Route("Home/Error")]
        public IActionResult Error(int? statusCode = null)
        {
            if (statusCode.HasValue)
            {
                if (statusCode == 404)
                {
                    ViewBag.ErrorMessage = "Page not found.";
                }
                else
                {
                    ViewBag.ErrorMessage = "An error occurred.";
                }
            }

            return View();
        }
    }
}
