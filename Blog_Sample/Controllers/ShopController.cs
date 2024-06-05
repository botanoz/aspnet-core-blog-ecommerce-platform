using Microsoft.AspNetCore.Mvc;

namespace Blog_Sample.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
