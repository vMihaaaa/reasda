using ShopArtApp.BussinessLogic.Interfaces.IServices;
using ShopArtApp.DataAcces.Repositories.Interfaces;

namespace ShopArtApp.BussinessLogic.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ShoppingCartService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

    }
}
/*     public async Task AddItemToCartAsync(int userId, int productId, int quantity)
     {
         var cartItem = await _unitOfWork.ShoppingCartRepository.GetByFilter(x => x.IdUser == userId && x.IdProduct == productId)
             .FirstOrDefaultAsync();

         if (cartItem == null)
         {
             cartItem = new ShoppingCart
             {
                 User.IdUser = ,
                 IdProduct = productId,
                 Cantity = quantity,
                 Total = quantity * (await _unitOfWork.ProductRepository.GetByIdAsync(productId)).Price
             };

             await _unitOfWork.ShoppingCartRepository.AddAsync(cartItem);
         }
         else
         {
             cartItem.Cantity += quantity;
             cartItem.Total += quantity * (await _unitOfWork.ProductRepository.GetByIdAsync(productId)).Price;

             _unitOfWork.ShoppingCartRepository.Update(cartItem);
         }

          _unitOfWork.Save();
     }

   public async Task RemoveItemFromCartAsync(int userId, int productId)
     {
         var cartItem = await _unitOfWork.ShoppingCartRepository.GetByFilter(x => x.IdUser == userId && x.IdProduct == productId)
             .FirstOrDefaultAsync();

         if (cartItem != null)
         {
            await _unitOfWork.ShoppingCartRepository.RemoveAsync(cartItem.IdShoppingCart);
              _unitOfWork.Save();
         }
     }

     public async Task<IEnumerable<ShoppingCart>> GetCartItemsAsync(int userId)
     {
         return await _unitOfWork.ShoppingCartRepository.GetByFilter(x => x.IdUser == userId)
             .Include(x => x.Products)
             .ToListAsync();
     }

  }
  }
*/

