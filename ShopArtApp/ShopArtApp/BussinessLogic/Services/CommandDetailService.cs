using ShopArtApp.BussinessLogic.Interfaces.IServices;
using ShopArtApp.DataAcces.Repositories.Interfaces;
using ShopArtApp.Models;

namespace ShopArtApp.BussinessLogic.Services
{
    public class CommandDetailService : ICommandDetailService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommandDetailService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<CommandDetail>> GetAllCommandDetailsAsync()
        {
            return await _unitOfWork.CommandDetailRepository.GetAllAsync();
        }

        public async Task<CommandDetail> GetCommandDetailByIdAsync(int id)
        {
            return await _unitOfWork.CommandDetailRepository.GetByIdAsync(id);
        }

        public async Task AddCommandDetailAsync(CommandDetail commandDetail)
        {
            await _unitOfWork.CommandDetailRepository.AddAsync(commandDetail);
            _unitOfWork.Save();
        }

        public void UpdateCommandDetailAsync(CommandDetail commandDetail)
        {
            _unitOfWork.CommandDetailRepository.Update(commandDetail);
            _unitOfWork.Save();
        }

        public async Task DeleteCommandDetailAsync(CommandDetail commandDetail)
        {
            await _unitOfWork.CommandDetailRepository.RemoveAsync(commandDetail.IdCommandDetail);
            _unitOfWork.Save();
        }
    }
}
