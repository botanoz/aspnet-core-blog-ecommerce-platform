using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.SystemServices;
using BusinessLayer.Services.UnitOfWork;
using BusinessLayer.Services.ViewModel;
using DataLayer.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var about = await _unitOfWork.Abouts.GetByIdAsync(1);
            
            return View(about);
        }
        [HttpPost]
        public async Task<IActionResult> AboutEdit(About aboutPage)
        {
            aboutPage.UpdatedDate = DateTime.Now;
            aboutPage.Id = 1;
            aboutPage.Name = "About";
            
           
             _unitOfWork.Abouts.Update(aboutPage);
                
                await _unitOfWork.CompleteAsync();
                return RedirectToAction(nameof(About));
  
        }

        public async Task<IActionResult> User()
        {
            var users = await _unitOfWork.Users.GetAllAsync();
            return View(users);
        }
        
        public async Task<IActionResult> DeleteBlog(int id)
        {
            var blogRepository = _unitOfWork.GetRepository<Blog>();
            var blog = await blogRepository.GetByIdAsync(id);
            if (blog == null)
            {
                return NotFound();
            }

            blogRepository.Remove(blog);
            await _unitOfWork.CompleteAsync();
            return RedirectToAction(nameof(Blog));
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

                var blog = await _unitOfWork.Blogs.GetByIdAsync(model.Id);
                if (blog == null)
                {
                    return NotFound();
                }

                if (model.Thumbnail != null)
                {
                string root = "images/blogs";
                    var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath,root);

                    blog.ThumbnailPath = await UploadImage.UploadThumbnailAsync(model.Thumbnail,uploadsFolder,root);
                }

                blog.Date = model.Date;
                blog.Title = model.Title;
                blog.Description = model.Description;
                blog.UserId = model.UserId;

                _unitOfWork.Blogs.Update(blog);
                await _unitOfWork.CompleteAsync();
                return RedirectToAction(nameof(Blog));
            

        }
       
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var result = await DeleteMethods.DeleteEntityAsync<Product>(id, _unitOfWork);
            if (!result)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Shop));
        }
        public async Task<IActionResult> EditShop(int id)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            var viewModel = new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                ImageUrl = product.ImageUrl
            };

            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> EditShop(ProductViewModel model)
        {

                var product = await _unitOfWork.Products.GetByIdAsync(model.Id);
                if (product == null)
                {
                    return NotFound();
                }

                if (model.Thumbnail != null)
                {
                    string root = "images/products";
                    var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath,root);

                    product.ImageUrl = await UploadImage.UploadThumbnailAsync(model.Thumbnail,uploadsFolder,root);
                }

                product.Name = model.Name;
                product.Description = model.Description;
                product.Price = model.Price;

                _unitOfWork.Products.Update(product);
                await _unitOfWork.CompleteAsync();
                return RedirectToAction(nameof(Shop));           

        }
       
        public async Task<IActionResult> DeletePortfolio(int id)
        {
            var result = await DeleteMethods.DeleteEntityAsync<Portfolio>(id, _unitOfWork);
            if (!result)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Portfolio));
        }
        public async Task<IActionResult> EditPortfolio(int id)
        {
            var portfolio = await _unitOfWork.Portfolios.GetByIdAsync(id);
            if (portfolio == null)
            {
                return NotFound();
            }

            var viewModel = new PortfolioViewModel
            {
                Id = portfolio.Id,
                Client = portfolio.Client,
                ProjectUrl = portfolio.ProjectUrl,
                Title = portfolio.Title,
                Description = portfolio.Description,
                UserId = portfolio.UserId,
                ThumbnailPath = portfolio.ProjectUrl
            };

            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> EditPortfolio(PortfolioViewModel model)
        {

                var portfolio = await _unitOfWork.Portfolios.GetByIdAsync(model.Id);
                if (portfolio == null)
                {
                    return NotFound();
                }

                if (model.Thumbnail != null)
                {
                string root = "images/portfolios";
                    var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath,root);
                    portfolio.ProjectUrl = await UploadImage.UploadThumbnailAsync(model.Thumbnail, uploadsFolder,root);
                }

                portfolio.Client = model.Client;
                portfolio.ProjectUrl = model.ProjectUrl;
                portfolio.Title = model.Title;
                portfolio.Description = model.Description;
                portfolio.UserId = model.UserId;

                _unitOfWork.Portfolios.Update(portfolio);
                await _unitOfWork.CompleteAsync();
                return RedirectToAction(nameof(Portfolio));


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
