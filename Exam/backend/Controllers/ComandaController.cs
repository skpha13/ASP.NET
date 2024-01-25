using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models.DTOs.ComandaDTOs;
using backend.Services.ComandaService;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class ComandaController : ControllerBase
    {
        private readonly IComandaService _comandaService;

        public ComandaController(IComandaService comandaService)
        {
            _comandaService = comandaService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetComenzi()
        {
            return Ok(await _comandaService.GetAll());
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateComanda([FromBody] CreateComandaDTO test)
        {
            await _comandaService.Create(test);
            return Ok();
        }

        [HttpPatch("update")]
        public async Task<IActionResult> UpdateComanda([FromBody] UpdateComandaDTO test)
        {
            await _comandaService.Update(test);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult DeleteComanda(Guid id)
        {
            _comandaService.Delete(id);
            return Ok();
        }
    }
}
