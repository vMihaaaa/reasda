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

        public void UpdateCommandAsync(Command command)
        {
            _unitOfWork.CommandRepository.Update(command);
              _unitOfWork.Save();
        }

        public async Task DeleteCommandAsync(Command command)
        {
          await  _unitOfWork.CommandRepository.RemoveAsync(command.IdCommand);
              _unitOfWork.Save();
        }
    }
}
