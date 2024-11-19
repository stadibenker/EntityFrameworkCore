namespace EntityFrameworkCore.Domain
{
    public class League : BaseDomainModel
    {
		public string Name { get; set; }
		public List<Team> Teams { get; set; } = new List<Team>() { }; // Navigation property (code-level)
	}
}
