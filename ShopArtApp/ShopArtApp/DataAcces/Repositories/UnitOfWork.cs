using ShopArtApp.DataAcces.Context;
using ShopArtApp.DataAcces.Repositories.Interfaces;
using ShopArtApp.Models;

namespace ShopArtApp.DataAcces.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShopArtAppContext _dbContext;
        private bool disposedValue;
        public IBaseRepository<BillAddress, int> BillAddressRepository { get; set; }
        public IBaseRepository<Category, int> CategoryRepository { get; set; }
        public IBaseRepository<Command, int> CommandRepository { get; set; }
        public IBaseRepository<CommandDetail, int> CommandDetailRepository { get; set; }
        public IBaseRepository<Product, int> ProductRepository { get; set; }
        public IBaseRepository<ShoppingCart, int> ShoppingCartRepository { get; set; }
        public IBaseRepository<User, int> UserRepository { get; set; }

        public UnitOfWork(IBaseRepository<BillAddress, int> billAddressRepository, IBaseRepository<Category, int> categoryRepository, IBaseRepository<Command, int> commandRepository,
            IBaseRepository<CommandDetail, int> commandDetailRepository, IBaseRepository<Product, int> productRepository, IBaseRepository<ShoppingCart, int> shoppingCartRepository,
            IBaseRepository<User, int> userRepository)
        {
            BillAddressRepository = billAddressRepository ?? throw new ArgumentNullException(nameof(billAddressRepository));
            CategoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
            CommandRepository = commandRepository ?? throw new ArgumentNullException(nameof(commandRepository));
            CommandDetailRepository = commandDetailRepository ?? throw new ArgumentNullException(nameof(commandDetailRepository));
            ProductRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            ShoppingCartRepository = shoppingCartRepository ?? throw new ArgumentNullException(nameof(shoppingCartRepository));
            UserRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _dbContext?.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

    }
}
