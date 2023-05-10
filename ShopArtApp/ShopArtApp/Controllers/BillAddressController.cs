using Microsoft.AspNetCore.Mvc;
using ShopArtApp.BussinessLogic.Interfaces.IServices;
using ShopArtApp.Models;

namespace ShopArtApp.Controllers
{
    public class BillAddressController : Controller
    {
        private readonly IBillAddressService _billAddressService;

        public BillAddressController(IBillAddressService billAddressService)
        {
            _billAddressService = billAddressService;
        }


        [HttpPost]
        public async Task<IActionResult> AddBillAddressAsync(BillAddress billAddress)
        {
            var result = await _billAddressService.AddBillAddressAsync(billAddress);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBillAddressAsync(int id)
        {
            var billAddress = await _billAddressService.GetBillAddressByIdAsync(id);

            if (billAddress == null)
            {
                return NotFound();
            }

            return Ok(billAddress);
        }

        /*  [HttpPut("{id}")]
          public async Task<IActionResult> UpdateBillAddressAsync(BillAddress billAddress)
          {
              try
              {
                   _billAddressService.UpdateBillAddressAsync(billAddress.IdBillAddress, billAddress.County,billAddress.Town, billAddress.Street,billAddress.Number, billAddress.PostalCode);

                  return Ok();
              }
              catch (Exception ex)
              {
                  return BadRequest(ex.Message);
              }
          }
        */
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBillAddress(int id)
        {
            var billAddress = await _billAddressService.GetBillAddressByIdAsync(id);

            if (billAddress == null)
            {
                return NotFound();
            }

            await _billAddressService.DeleteBillAddressAsync(billAddress.IdBillAddress);

            return Ok();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
