using BusinessLayer.Services.UnitOfWork;
using DataLayer.Model;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Sample.Controllers
{
    public class ShopController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public ShopController(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork=_unitOfWork;
        }
        public async Task<IActionResult> Index()
        {

            IEnumerable<Product> productList = await unitOfWork.Products.GetAllAsync();
            ViewBag.Result = productList.Count();
            return View(productList);
        }
    }
}
