namespace EntityFrameworkCore.Domain
{
    public class League : BaseDomainModel
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Team> Teams { get; set; } // Navigation property (code-level)
	}
}
