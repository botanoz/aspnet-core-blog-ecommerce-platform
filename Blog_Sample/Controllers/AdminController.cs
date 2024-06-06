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
        private readonly IUnitOfWork _unitOfWork;

        public AdminController(
            UserManager<ApplicationUser> userManager,
            IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Portfolio()
        {
            var portfolios = await _unitOfWork.Portfolios.GetAllAsync();
            return View(portfolios);
        }

        public async Task<IActionResult> Shop()
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            return View(products);
        }

        public async Task<IActionResult> Blog()
        {
            var blogs = await _unitOfWork.Blogs.GetAllAsync();
            return View(blogs);
        }

        public async Task<IActionResult> Setting()
        {
            var settings = await _unitOfWork.Settings.GetAllAsync();
            return View(settings);
        }

        public async Task<IActionResult> About()
        {
            var abouts = await _unitOfWork.Abouts.GetAllAsync();
            return View(abouts);
        }

        public async Task<IActionResult> User()
        {
            var users = await _unitOfWork.Users.GetAllAsync();
            return View(users);
        }

        [HttpPost]
        public async Task<IActionResult> SaveSettings(IEnumerable<Setting> settings)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.Settings.AddRangeAsync(settings);
                await _unitOfWork.CompleteAsync();
                return RedirectToAction(nameof(Setting));
            }
            return View(settings);
        }
    }
}
