using ShopArtApp.BussinessLogic.Interfaces.IServices;
using ShopArtApp.DataAcces.Repositories.Interfaces;
using ShopArtApp.Models;

namespace ShopArtApp.BussinessLogic.Services
{
    public class CommandService : ICommandService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Command>> GetAllCommandsAsync()
        {
            return await _unitOfWork.CommandRepository.GetAllAsync();
        }

        public async Task<Command> GetCommandByIdAsync(int id)
        {
            return await _unitOfWork.CommandRepository.GetByIdAsync(id);
        }

        public async Task<Command> AddCommandAsync(Command command)
        {
            await _unitOfWork.CommandRepository.AddAsync(command);
            _unitOfWork.Save();
            return command;
        }
        public List<Command> GetCommandsByUserId(string userId)
        {
            var commands = _unitOfWork.CommandRepository.GetByFilter(c => c.User.UserId.ToString() == userId).ToList();
            var user = _unitOfWork.UserRepository.GetByFilter(c => c.UserId == 1).ToList();
            var billAddresses = _unitOfWork.BillAddressRepository.GetByFilter(c => c.User.UserId == 1).ToList();

            foreach (var command in commands)
            {
                command.User.UserId = user[0].UserId;
                //   command.BillAddress = billAddresses[0];
            }
            return commands;
        }
        public void UpdateCommandAsync(Command command)
        {
            _unitOfWork.CommandRepository.Update(command);
            _unitOfWork.Save();
        }

        public async Task DeleteCommandAsync(Command command)
        {
            await _unitOfWork.CommandRepository.RemoveAsync(command.IdCommand);
            _unitOfWork.Save();
        }
    }
}
