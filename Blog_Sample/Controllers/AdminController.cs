using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.UnitOfWork;
using DataLayer.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog_Sample.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IBlogService _blogService;
        private readonly IPortfolioService _portfolioService;
        private readonly IProductService _productService;
        private readonly IAboutService _aboutService;
        private readonly IUserService _userService;
        private readonly ISettingService _settingService;
        private readonly IUnitOfWork _unitOfWork;

        public AdminController(
            UserManager<ApplicationUser> userManager,
            IBlogService blogService,
            IPortfolioService portfolioService,
            IProductService productService,
            IAboutService aboutService,
            IUserService userService,
            ISettingService settingService,
            IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _blogService = blogService;
            _portfolioService = portfolioService;
            _productService = productService;
            _aboutService = aboutService;
            _userService = userService;
            _settingService = settingService;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Portfolio()
        {
            var portfolios = await _portfolioService.GetAllAsync();
            return View(portfolios);
        }

        public async Task<IActionResult> Shop()
        {
            var products = await _productService.GetAllAsync();
            return View(products);
        }

        public async Task<IActionResult> Blog()
        {
            var blogs = await _blogService.GetAllAsync();
            return View(blogs);
        }

        public IActionResult Setting()
        {
            // Load settings
            return View();
        }

        public async Task<IActionResult> About()
        {
            var abouts = await _aboutService.GetAllAsync();
            return View(abouts);
        }

        public async Task<IActionResult> User()
        {
            var users = await _userService.GetAllAsync();
            return View(users);
        }

        [HttpPost]
        public async Task<IActionResult> SaveSettings(Setting settings)
        {
            if (ModelState.IsValid)
            {
                await _settingService.AddAsync(settings);
                await _unitOfWork.CompleteAsync();
                return RedirectToAction(nameof(Setting));
            }
            return View(settings);
        }
    }
}
