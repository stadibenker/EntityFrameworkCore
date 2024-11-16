using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Data
{
	public class FootballDbContext : DbContext
	{
		public DbSet<Team> Teams { get; set; }
		public DbSet<Coach> Coaches { get; set; }
		public DbSet<League> Leagues { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost;Database=FootballEFCore;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true");
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Team>().HasData(
				new Team { Id = 1, Name = "Test Team", CreatedDate = new DateTime(2024, 11, 16), LeagueId = 1 }
			);

			modelBuilder.Entity<League>().HasData(
				new League { Id = 1, Name = "Best League", CreatedDate = new DateTime(2024, 11, 15) }
			);
		}
	}
}
