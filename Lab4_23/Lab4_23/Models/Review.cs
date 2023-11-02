using Lab4_23.Models.Base;

namespace Lab4_23.Models
{
	public class Review : BaseEntity
	{
		public string Text { get; set; }
		public int numberStars { get; set; }
		public Post Post { get; set; }
		public Guid PostId { get; set; }
	}
}
