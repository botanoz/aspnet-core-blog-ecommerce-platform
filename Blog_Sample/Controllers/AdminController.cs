using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.UnitOfWork;
using BusinessLayer.Services.ViewModel;
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
        private readonly IOrderService _orderService;

        public AdminController(
            UserManager<ApplicationUser> userManager,
            IUnitOfWork unitOfWork,IOrderService orderService)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
            _orderService=orderService;

        }

        public async Task<IActionResult> Index()
        {
           
            AdminDashboardViewModel viewModel = new AdminDashboardViewModel()
            {
                TotalOrders= (await _unitOfWork.Orders.GetAllAsync()).Count(),
                TotalProducts = (await _unitOfWork.Products.GetAllAsync()).Count(),
                TotalBlogs = (await _unitOfWork.Blogs.GetAllAsync()).Count(),
                TotalPortfolios = (await _unitOfWork.Portfolios.GetAllAsync()).Count(),
                PendingOrders= await _orderService.GetCountOrders(OrderStatus.Pending),
                TotalUsers= (await _unitOfWork.Users.GetAllAsync() ).Count(),
                TodayVisitors=0
                
              
            };
            return View(viewModel);
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
