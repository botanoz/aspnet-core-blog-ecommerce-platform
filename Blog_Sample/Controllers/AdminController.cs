using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.UnitOfWork;
using BusinessLayer.Services.ViewModel;
using DataLayer.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
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
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOrderService _orderService;
        private readonly IBlogService _blogService;
        private readonly IPortfolioService _portfolioService;

        public AdminController(
            UserManager<ApplicationUser> userManager,
            IUnitOfWork unitOfWork,IOrderService orderService, IBlogService blogService, IPortfolioService portfolioService, IWebHostEnvironment webHostEnvironment)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
            _orderService = orderService;
            _blogService = blogService;
            _portfolioService = portfolioService;
            _webHostEnvironment = webHostEnvironment;
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
            var portfolios = await _portfolioService.GetPortfolioDataListAsync();
            return View(portfolios);
        }

        public async Task<IActionResult> Shop()
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            return View(products);
        }

        public async Task<IActionResult> Blog()
        {
            var blogs = await _blogService.GetBlogDataListAsync();
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

        public async Task<IActionResult> EditBlog(int id)
        {
            var blog = await _unitOfWork.Blogs.GetByIdAsync(id);
            if (blog == null)
            {
                return NotFound();
            }

            var viewModel = new BlogViewModel
            {
                Id = blog.Id,
                Date = blog.Date,
                Title = blog.Title,
                Description = blog.Description,
                UserId = blog.UserId,
                ThumbnailPath = blog.ThumbnailPath
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditBlog(BlogViewModel model)
        {
            if (ModelState.IsValid)
            {
                var blog = await _unitOfWork.Blogs.GetByIdAsync(model.Id);
                if (blog == null)
                {
                    return NotFound();
                }

                if (model.Thumbnail != null)
                {
                    var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images/blogs");
                    Directory.CreateDirectory(uploadsFolder); 
                    var fileName = Path.GetFileNameWithoutExtension(model.Thumbnail.FileName);
                    var extension = Path.GetExtension(model.Thumbnail.FileName);
                    var newFileName = $"{fileName}_{DateTime.Now:yyyyMMddHHmmss}{extension}";
                    var filePath = Path.Combine(uploadsFolder, newFileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await model.Thumbnail.CopyToAsync(stream);
                    }

                    blog.ThumbnailPath = $"~/images/blogs/{newFileName}";
                }

                blog.Date = model.Date;
                blog.Title = model.Title;
                blog.Description = model.Description;
                blog.UserId = model.UserId;

                _unitOfWork.Blogs.Update(blog);
                await _unitOfWork.CompleteAsync();
                return RedirectToAction(nameof(Blog));
            }
            return View(model);
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
