using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab4_23.Models.Base
{
	public class BaseEntity: IBaseEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }
		public DateTime? DateCreated { get; set; }
		public DateTime? LastModified{ get; set; }
	}
}
