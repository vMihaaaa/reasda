using ShopArtApp.BussinessLogic.Interfaces.IServices;
using ShopArtApp.DataAcces.Repositories.Interfaces;
using ShopArtApp.Models;

namespace ShopArtApp.BussinessLogic.Services
{
    public class BillAddressService : IBillAddressService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BillAddressService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<BillAddress> AddBillAddressAsync(BillAddress billAddress)
        {
            await _unitOfWork.BillAddressRepository.AddAsync(billAddress);
            _unitOfWork.Save();

            return billAddress;
        }
        public async Task<BillAddress> GetBillAddressByIdAsync(int id)
        {
            return await _unitOfWork.BillAddressRepository.GetByIdAsync(id);
        }
        public async Task UpdateBillAddressAsync(int id, string county, string town, string street, int number, int postalCode)
        {
            var billAddress = await _unitOfWork.BillAddressRepository.GetByIdAsync(id);

            if (billAddress == null)
            {
                throw new Exception("Bill address not found");
            }

            billAddress.County = county;
            billAddress.Town = town;
            billAddress.Street = street;
            billAddress.Number = number;
            billAddress.PostalCode = postalCode;

            _unitOfWork.Save();
        }


        public async Task DeleteBillAddressAsync(int id)
        {
            var billAddress = await _unitOfWork.BillAddressRepository.GetByIdAsync(id);

            if (billAddress == null)
            {
                throw new Exception("Bill address not found");
            }

            await _unitOfWork.BillAddressRepository.RemoveAsync(billAddress.IdBillAddress);
            _unitOfWork.Save();
        }
    }
}
