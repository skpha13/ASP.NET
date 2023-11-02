﻿using Lab4_23.Models.Base;

namespace Lab4_23.Models
{
	public class ONG : BaseEntity
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public User User { get; set; }
		public Guid UserId { get; set; }
		public ICollection<ONGHasPosts> HasPosts { get; set; }
	}
}
