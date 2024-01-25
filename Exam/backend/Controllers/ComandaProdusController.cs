using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models.DTOs.ComandaDTOs;
using backend.Models.DTOs.ProdusDTOs;
using backend.Models.DTOs.RelatieDTOs;
using backend.Services.ComandaProdusService;
using backend.Services.ComandaService;
using backend.Services.ProdusService;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class ComandaProdusController : ControllerBase
    {
        private readonly IComandaProdusService _comandaProdusService;

        public ComandaProdusController(IComandaProdusService comandaProdusService)
        {
            _comandaProdusService = comandaProdusService;
        }
        
        [HttpPost("assign")]
        public async Task<IActionResult> CreateProdus([FromBody] CreateRelatieDTO test)
        {
            await _comandaProdusService.Create(test);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult DeleteProdus(Guid id)
        {
            _comandaProdusService.Delete(id);
            return Ok();
        }
    }
}
