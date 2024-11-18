﻿namespace EntityFrameworkCore.Domain
{
	public class Match : BaseDomainModel
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public decimal TicketPrice { get; set; }


		public int HomeTeamScore { get; set; }
		public int AwayTeamScore { get; set; }

		public int HomeTeamId { get; set; }
		public Team HomeTeam { get; set; }
		public int AwayTeamId { get; set; }
		public Team AwayTeam { get; set; }
	}
}
