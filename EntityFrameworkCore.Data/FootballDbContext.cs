using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EntityFrameworkCore.Data
{
	public class FootballDbContext : DbContext
	{
		public DbSet<Team> Teams { get; set; }
		public DbSet<Coach> Coaches { get; set; }
		public DbSet<League> Leagues { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost;Database=FootballEFCore;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true")
				.LogTo(Console.WriteLine, LogLevel.Information)
				.EnableSensitiveDataLogging()
				.EnableDetailedErrors();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Team>().HasData(
				new Team { Id = 1, Name = "Test Team", CreatedDate = new DateTime(2024, 11, 16), LeagueId = 1 }
			);

			modelBuilder.Entity<Team>().HasData(
				new Team { Id = 2, Name = "The Local Team", CreatedDate = new DateTime(2024, 11, 19), LeagueId = 1 }
			);

			modelBuilder.Entity<League>().HasData(
				new League { Id = 1, Name = "Best League", CreatedDate = new DateTime(2024, 11, 15) }
			);

			modelBuilder.Entity<Team>().HasIndex(x => x.Name).IsUnique();

			modelBuilder.Entity<Team>().HasMany(x => x.HomeMatches)
				.WithOne(x => x.HomeTeam)
				.HasForeignKey(x => x.HomeTeamId)
				.IsRequired()
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<Team>().HasMany(x => x.AwayMatches)
				.WithOne(x => x.AwayTeam)
				.HasForeignKey(x => x.AwayTeamId)
				.IsRequired()
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
