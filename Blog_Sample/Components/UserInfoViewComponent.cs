using DataLayer.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;


namespace Blog_Sample.Components
{
    public class UserInfoViewComponent: ViewComponent
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserInfoViewComponent(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            return View(user);
        }
    }
}
