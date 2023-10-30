using Lab3_23.Models.Base;

namespace Lab3_23.Models
{
	public class Movie: BaseEntity
	{
		public string name { get; set; }
		public string? description { get; set; }
		public int rating { get; set; }
		public float? duration { get; set; }
	}
}
