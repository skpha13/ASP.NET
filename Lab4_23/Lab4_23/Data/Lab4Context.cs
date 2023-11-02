using Lab4_23.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab4_23.Data
{
	public class Lab4Context: DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<ONG> ONGS { get; set; }
		public DbSet<Need> Needs { get; set; }
		public DbSet<PostHasNeeds> PostHasNeedsRelation { get; set; }
		public DbSet<ONGHasPosts> ONGHasPostsRelation { get; set; }


		public Lab4Context(DbContextOptions<Lab4Context> options): base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Post>()
			   .HasMany(p => p.Reviews)
			   .WithOne(p => p.Post)
			   .HasForeignKey(p => p.PostId);

			modelBuilder.Entity<ONG>()
				.HasOne(u => u.User)
				.WithOne(u => u.ONG)
				.HasForeignKey<ONG>(u => u.Id);

			// m-m relation between Posts and Needs
			modelBuilder.Entity<PostHasNeeds>().HasKey(obj => new { obj.PostId, obj.NeedId });
			modelBuilder.Entity<PostHasNeeds>()
				.HasOne(p => p.Post)
				.WithMany(p => p.HasNeeds)
				.HasForeignKey(p => p.PostId);
			modelBuilder.Entity<PostHasNeeds>()
				.HasOne(p => p.Need)
				.WithMany(p => p.HasPosts)
				.HasForeignKey(p => p.NeedId);

			// m-m relation between ONG and Posts
			modelBuilder.Entity<ONGHasPosts>().HasKey(obj => new { obj.ONGId, obj.PostId });
			modelBuilder.Entity<ONGHasPosts>()
				.HasOne(p => p.Post)
				.WithMany(p => p.HasONG)
				.HasForeignKey(p => p.ONGId);
			modelBuilder.Entity<ONGHasPosts>()
				.HasOne(p => p.ONG)
				.WithMany(p => p.HasPosts)
				.HasForeignKey(p => p.PostId);

			base.OnModelCreating(modelBuilder);
		}
	}
}
