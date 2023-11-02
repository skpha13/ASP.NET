using Lab4_23.Models.Base;

namespace Lab4_23.Models
{
	public class ONGHasPosts: BaseEntity
	{
		public Post Post { get; set; }
		public Guid PostId { get; set; }
		public ONG ONG { get; set; }
		public Guid ONGId { get; set; }
	}
}
