namespace EntityFrameworkCore.Domain
{
	public class Team : BaseDomainModel
	{
		public string Name { get; set; }

		public League? League { get; set; } // Navigation property (code-level)
		public int? LeagueId { get; set; } // Foreign key (db-level)
		public Coach Coach { get; set; }
		public int CoachId { get; set; }

		public List<Match> HomeMatches { get; set; } = new List<Match>() { };
		public List<Match> AwayMatches { get; set; } = new List<Match>() { };
	}
}
