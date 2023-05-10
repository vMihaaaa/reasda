using Microsoft.AspNetCore.Mvc;
using ShopArtApp.BussinessLogic.Interfaces.IServices;

namespace ShopArtApp.Controllers
{

    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCartService _shoppingCartServices;

        public ShoppingCartController(IShoppingCartService shoppingCartServices)
        {
            _shoppingCartServices = shoppingCartServices;
        }
        /*
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddItemToCartAsync(int productId, int quantity)
        {
            int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            await _shoppingCartServices.AddItemToCartAsync(userId, productId, quantity);

            return Ok();
        }
        
        
        [HttpPost]
        [Route("remove")]
        public async Task<IActionResult> RemoveItemFromCartAsync(int productId)
        {
            int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            await _shoppingCartServices.RemoveItemFromCartAsync(userId, productId);

            return Ok();
        }

        [HttpGet]
        [Route("items")]
        public async Task<IActionResult> GetCartItemsAsync()
        {
            int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            var cartItems = null; await _shoppingCartServices.GetCartItemsAsync(userId);

            return Ok(cartItems);
        }
     */
    }
}
