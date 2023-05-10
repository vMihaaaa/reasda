using Microsoft.AspNetCore.Mvc;
using ShopArtApp.BussinessLogic.Interfaces.IServices;
using ShopArtApp.Models;

namespace ShopArtApp.Controllers
{
    public class CommandDetailController : Controller
    {
        private readonly ICommandDetailService _commandDetailService;

        public CommandDetailController(ICommandDetailService commandDetailService)
        {
            _commandDetailService = commandDetailService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCommandDetailsAsync()
        {
            var commandDetails = await _commandDetailService.GetAllCommandDetailsAsync();
            return Ok(commandDetails);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommandDetailByIdAsync(int id)
        {
            var commandDetail = await _commandDetailService.GetCommandDetailByIdAsync(id);

            if (commandDetail == null)
            {
                return NotFound();
            }

            return Ok(commandDetail);
        }

        [HttpPost]
        public async Task<IActionResult> AddCommandDetailAsync(CommandDetail commandDetail)
        {
            await _commandDetailService.AddCommandDetailAsync(commandDetail);
            return Ok(commandDetail);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCommandDetailAsync(CommandDetail commandDetail)
        {
            _commandDetailService.UpdateCommandDetailAsync(commandDetail);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommandDetailAsync(int id)
        {
            var commandDetail = await _commandDetailService.GetCommandDetailByIdAsync(id);

            if (commandDetail == null)
            {
                return NotFound();
            }

            await _commandDetailService.DeleteCommandDetailAsync(commandDetail);

            return Ok();
        }
    }

}
