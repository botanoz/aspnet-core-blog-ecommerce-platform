using Blog_Sample.Models;
using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.UnitOfWork;
using DataLayer.Repository.SpecificRepository.Class;
using DataLayer.Repository.SpecificRepository.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blog_Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork unitOfWork;
        private readonly IAboutService aboutService;

        public HomeController(ILogger<HomeController> logger,IUnitOfWork _unitOfWork, IAboutService _aboutService)
        {
            _logger = logger;
            this.unitOfWork = _unitOfWork;
            this.aboutService= _aboutService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> About()
        {
            var aboutdata = await aboutService.GetAboutPageDataAsync();
            return View(aboutdata);
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
