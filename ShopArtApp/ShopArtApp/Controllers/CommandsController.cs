using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopArtApp.BussinessLogic.Interfaces.IServices;
using ShopArtApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ShopArtApp.Controllers
{
    //[Route("api/[controller]")]
    public class CommandsController : Controller
    {
        private readonly ICommandService _commandService;
        public CommandsController(ICommandService commandService)
        {
            _commandService = commandService;
        }
       
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<Command>>> GetAllCommandsAsync()
        {
            var commands = await _commandService.GetAllCommandsAsync();
            return Ok(commands);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Command>> GetCommandByIdAsync(int id)
        {
            var command = await _commandService.GetCommandByIdAsync(id);
            if (command == null)
            {
                return NotFound();
            }
            return Ok(command);
        }

        [HttpPost]
        public async Task<ActionResult<Command>> AddCommandAsync(Command command)
        {
            var newCommand = await _commandService.AddCommandAsync(command);
            return CreatedAtAction(nameof(GetCommandByIdAsync), new { id = newCommand.IdCommand }, newCommand);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCommandAsync(int id, Command command)
        {
            if (id != command.IdCommand)
            {
                return BadRequest();
            } 
             _commandService.UpdateCommandAsync(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommandAsync(int id)
        {
            var command = await _commandService.GetCommandByIdAsync(id);

            if (command == null)
            {
                return NotFound();
            }
            await _commandService.DeleteCommandAsync(command);
            return Ok();
        }
        public async Task<IActionResult> Details(int id)
        {
            if (id == null || _commandService.GetAllCommandsAsync == null)
            {
                return NotFound();
            }

            var test = await _commandService.GetCommandByIdAsync(id);
                
            if (test == null)
            {
                return NotFound();
            }

            return View(test);
        }
    }
}
