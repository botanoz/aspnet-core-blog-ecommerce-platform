using BusinessLayer.Services.SipecificServices.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Sample.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public async Task<IActionResult> Index()
        {
            var blogs = await _blogService.GetAllAsync();
            return View(blogs);
        }
        public IActionResult BlogPost()
        {
            return View();
        }
    }
}
