using Lab4_23.Data;
using Lab4_23.Models;
using Lab4_23.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab4_23.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DatabaseController : ControllerBase
	{
		private readonly Lab4Context _lab4Context;

		public DatabaseController(Lab4Context lab4Context)
		{
			_lab4Context = lab4Context;
		}

		[HttpGet("User")]
		public async Task<IActionResult> GetUser()
		{
			return Ok(await _lab4Context.Users.ToListAsync());
		}

		[HttpPost("CreateUser")]
		public async Task<IActionResult> CreateUser(UserDTO user)
		{
			var newUser = new User
			{
				Id = Guid.NewGuid(),
				DateCreated = DateTime.Now,
				LastModified = DateTime.Now,
				Name = user.Name,
				Email = user.Email
			};

			await _lab4Context.AddAsync(newUser);
			await _lab4Context.SaveChangesAsync();
			return Ok(newUser);
		}
	}
}
