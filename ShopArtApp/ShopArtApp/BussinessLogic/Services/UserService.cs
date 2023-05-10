using Microsoft.EntityFrameworkCore;
using ShopArtApp.BussinessLogic.Services.IServices;
using ShopArtApp.DataAcces.Repositories.Interfaces;
using ShopArtApp.Models;

namespace ShopArtApp.BussinessLogic.Services.Service
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Register(User user)
        {
            if (await _unitOfWork.UserRepository.GetByFilter(u => u.MailAddress == user.MailAddress).AnyAsync())
            {
                return false; // User already exists
            }

            user.DateOfSignIn = DateTime.Now;

            await _unitOfWork.UserRepository.AddAsync(user);
            _unitOfWork.Save();

            return true;
        }
        public User Update(User user)
        {
            _unitOfWork.UserRepository.Update(user);
            _unitOfWork.Save();
            return user;
        }

        public async Task<User> Login(string mailAddress, string password)
        {
            return await _unitOfWork.UserRepository.GetByFilter(u => u.MailAddress == mailAddress && u.Password == password).FirstOrDefaultAsync();
        }

        public void Logout()
        {
            // There is no need to implement anything here as logging out is typically handled on the client side.
        }

        public async Task<User> GetUserById(int id)
        {
            return await _unitOfWork.UserRepository.GetByIdAsync(id);
        }
    }
}