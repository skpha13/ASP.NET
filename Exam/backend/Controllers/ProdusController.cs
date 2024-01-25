using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models.DTOs.ComandaDTOs;
using backend.Models.DTOs.ProdusDTOs;
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
    public class ProdusController : ControllerBase
    {
        private readonly IProdusService _produsService;

        public ProdusController(IProdusService produsService)
        {
            _produsService = produsService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetProduse()
        {
            return Ok(await _produsService.GetAll());
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateProdus([FromBody] CreateProdusDTO test)
        {
            await _produsService.Create(test);
            return Ok();
        }

        [HttpPatch("update")]
        public async Task<IActionResult> UpdateProdus([FromBody] UpdateProdusDTO test)
        {
            await _produsService.Update(test);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult DeleteProdus(Guid id)
        {
            _produsService.Delete(id);
            return Ok();
        }
    }
}
