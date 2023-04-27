using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShopArtApp.BussinessLogic.Services.IServices;
using ShopArtApp.BussinessLogic.Services.Service;
using ShopArtApp.DataAcces.Context;
using ShopArtApp.Models;

namespace ShopArtApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult MyAccount()
        {
            var currentUserId = 1;
            var currentUser = _userService.GetUserById(currentUserId);
            if (currentUser == null)
            {
                return NotFound();
            }

            return View(currentUser);
        }
    }
}
