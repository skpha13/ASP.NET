using Lab4_23.Models.Base;

namespace Lab4_23.Models
{
	public class OngHasPosts: BaseEntity
	{
		public Post Post { get; set; }
		public Guid PostId { get; set; }
		public Ong Ong { get; set; }
		public Guid OngId { get; set; }
	}
}
