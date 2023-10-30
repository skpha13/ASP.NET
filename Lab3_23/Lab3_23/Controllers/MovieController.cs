using Lab3_23.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Lab3_23.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MovieController : Controller
	{
		private readonly Lab3Context _lab3Context;

		public MovieController(Lab3Context lab3Context)
		{
			_lab3Context = lab3Context;
		}

		[HttpGet]
		public async Task<IActionResult> getAllMovies()
		{
			return Ok(await _lab3Context.Movies.ToListAsync());
		}
	}
}
