
using ShopArtApp.Models;

namespace ShopArtApp.BussinessLogic.Interfaces.IServices
{
    public interface ICommandService
    {
        Task<IEnumerable<Command>> GetAllCommandsAsync();
        Task<Command> GetCommandByIdAsync(int id);
        Task<Command> AddCommandAsync(Command command);
        void UpdateCommandAsync(Command command);
        Task DeleteCommandAsync(Command command);
        public List<Command> GetCommandsByUserId(string userId);
    }

}
