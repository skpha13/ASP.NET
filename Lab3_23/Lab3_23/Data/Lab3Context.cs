using Lab3_23.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab3_23.Data
{
    public class Lab3Context: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public Lab3Context(DbContextOptions<Lab3Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { 
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.NewGuid(),
                name = "Scream",
                rating = 9,
                duration = 76.5f
            });

			modelBuilder.Entity<Movie>().HasData(new Movie
			{
				Id = Guid.NewGuid(),
				name = "Top Gun: Maverick",
                description = "A movie in which the main actor manages to save the world",
				rating = 10,
				duration = 125.30f,
                DateTime = DateTime.Now,
                LastModified = DateTime.Now
			});
		}
    }
}
