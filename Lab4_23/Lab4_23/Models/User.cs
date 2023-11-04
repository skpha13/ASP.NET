using Lab4_23.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Lab4_23.Models
{
	public class User : BaseEntity
	{
		public string Name { get; set; } = string.Empty;
		[Required]
		[EmailAddress]
		public string Email { get; set; }

		public Ong? Ong { get; set; }
		public Guid? OngId { get; set; }
	}
}
