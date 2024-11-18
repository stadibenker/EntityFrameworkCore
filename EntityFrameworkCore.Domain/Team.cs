namespace EntityFrameworkCore.Domain
{
	public class Team : BaseDomainModel
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public League League { get; set; } // Navigation property (code-level)
		public int LeagueId { get; set; } // Foreign key (db-level)
		public List<Match> HomeMatches { get; set; }
		public List<Match> AwayMatches { get; set; }
	}
}
