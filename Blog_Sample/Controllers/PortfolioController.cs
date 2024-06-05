using BusinessLayer.Services.SipecificServices.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Sample.Controllers
{
    public class PortfolioController : Controller
    {
        private IPortfolioService _portfolioService;

        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public async Task<IActionResult> Index()
        {
            var portfolios = await _portfolioService.GetAllAsync();
            return View(portfolios);
        }
        public IActionResult PortfolioPost()
        {
            return View();
        }
    }
}
