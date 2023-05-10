using Microsoft.AspNetCore.Mvc;
using ShopArtApp.BussinessLogic.Services.IServices;

namespace ShopArtApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<IActionResult> Details()
        {
            var currentUser = await _userService.GetUserById(1);
            if (currentUser == null)
            {
                return NotFound();
            }

            return View(currentUser);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var user = await _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
    }
}
