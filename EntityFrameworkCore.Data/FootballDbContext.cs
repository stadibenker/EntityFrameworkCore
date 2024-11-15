using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Data
{
	public class FootballDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost;Database=FootballEFCore;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true");
			base.OnConfiguring(optionsBuilder);
		}

		public DbSet<Team> Teams { get; set; }
		public DbSet<Coach> Coaches { get; set; }
	}
}
