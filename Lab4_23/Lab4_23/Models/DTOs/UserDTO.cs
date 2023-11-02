using System.ComponentModel.DataAnnotations;

namespace Lab4_23.Models.DTOs
{
	public class UserDTO
	{
		public string Name { get; set; } = string.Empty;
		[Required]
		[EmailAddress]
		public string Email { get; set; }
	}
}
