using ShopArtApp.Models;

namespace ShopArtApp.BussinessLogic.Services.IServices
{
    public interface IUserService
    {
        Task<User> Login(string mailAdress, string password);
        void Logout();
        Task<bool> Register(User user);
        Task<User> GetUserById(int id);
        User Update(User user);

    }
}
