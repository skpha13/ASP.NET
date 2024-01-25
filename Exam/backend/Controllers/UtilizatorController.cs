using backend.Models;
using backend.Models.DTOs.UserDTOs;
using backend.Services.TestService;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class UtilizatorController : ControllerBase
    {
        private readonly IUtilizatorService _utilizatorService;

        public UtilizatorController(IUtilizatorService utilizatorService)
        {
            _utilizatorService = utilizatorService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetUtilizatori()
        {
            return Ok(await _utilizatorService.GetAll());
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateUtilizator([FromBody] CreateUserDTO test)
        {
            await _utilizatorService.Create(test);
            return Ok();
        }

        [HttpPatch("update")]
        public async Task<IActionResult> UpdateUtilizator([FromBody] UpdateUserDTO test)
        {
            await _utilizatorService.Update(test);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult DeleteUtilizator(Guid id)
        {
            _utilizatorService.Delete(id);
            return Ok();
        }
    }
}
