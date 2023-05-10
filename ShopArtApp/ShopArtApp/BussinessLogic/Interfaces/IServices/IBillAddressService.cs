using ShopArtApp.Models;

namespace ShopArtApp.BussinessLogic.Interfaces.IServices
{
    public interface IBillAddressService
    {
        Task<BillAddress> GetBillAddressByIdAsync(int id);
        Task UpdateBillAddressAsync(int id, string county, string town, string street, int number, int postalCode);
        Task DeleteBillAddressAsync(int billAddressId);
        Task<BillAddress> AddBillAddressAsync(BillAddress billAddress);
    }
}
