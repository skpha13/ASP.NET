using Lab4_23.Models.Base;

namespace Lab4_23.Models
{
	public class Need: BaseEntity
	{
		public string Name { get; set; }
		public int Quantity { get; set; }
		public ICollection<PostHasNeeds> HasPosts { get; set; }
	}
}
