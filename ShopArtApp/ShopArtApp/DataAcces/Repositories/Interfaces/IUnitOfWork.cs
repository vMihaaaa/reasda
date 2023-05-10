using ShopArtApp.Models;

namespace ShopArtApp.DataAcces.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<BillAddress, int> BillAddressRepository { get; set; }
        IBaseRepository<Category, int> CategoryRepository { get; set; }
        IBaseRepository<Command, int> CommandRepository { get; set; }
        IBaseRepository<CommandDetail, int> CommandDetailRepository { get; set; }
        IBaseRepository<Product, int> ProductRepository { get; set; }
        IBaseRepository<ShoppingCart, int> ShoppingCartRepository { get; set; }
        IBaseRepository<User, int> UserRepository { get; set; }

        void Save();
    }
}
