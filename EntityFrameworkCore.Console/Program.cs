using EntityFrameworkCore.Data;
using Microsoft.EntityFrameworkCore;

using var context = new FootballDbContext();

await GetAllTeamsNames();
await GetAllTeams();
await GetTeamById(1);
await GetTeamById(2);

async Task GetAllTeams()
{
	var teams = await context.Teams.ToListAsync();

	teams.ForEach(x => Console.WriteLine(x.Id + " - " + x.Name));
}

async Task GetAllTeamsNames()
{
	var teams = await context.Teams.Select(x => x.Name).ToListAsync();

	teams.ForEach(Console.WriteLine);
}

async Task GetTeamById(int id)
{
	var team = await context.Teams.FindAsync(id);

	if(team != null)
	{
		Console.WriteLine(team.Id + " - " + team.Name);
	}
}

