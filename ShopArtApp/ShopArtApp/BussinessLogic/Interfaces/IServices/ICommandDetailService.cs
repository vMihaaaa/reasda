using ShopArtApp.Models;

namespace ShopArtApp.BussinessLogic.Interfaces.IServices
{
    public interface ICommandDetailService
    {
        Task<IEnumerable<CommandDetail>> GetAllCommandDetailsAsync();
        Task<CommandDetail> GetCommandDetailByIdAsync(int id);
        Task AddCommandDetailAsync(CommandDetail commandDetail);
        void UpdateCommandDetailAsync(CommandDetail commandDetail);
        Task DeleteCommandDetailAsync(CommandDetail commandDetail);
    }

}
