using Lab4_23.Models.Base;

namespace Lab4_23.Models
{
	public class PostHasNeeds: BaseEntity
	{
		public Post Post { get; set; }
		public Guid PostId { get; set; }
		public Need Need { get; set; }
		public Guid NeedId { get; set; }
	}
}
