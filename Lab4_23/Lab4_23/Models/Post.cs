using Lab4_23.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Lab4_23.Models
{
	public class Post : BaseEntity
	{
		[Required]
		[StringLength(50)]
		public string Title { get; set; }
		[Required]
		[StringLength(1000)]
		public string Description { get; set; }
		public ICollection<Review>? Reviews { get; set; }
		public ICollection<PostHasNeeds>? HasNeeds { get; set; }
		public ICollection<OngHasPosts>? HasOng { get; set; }
	}
}
