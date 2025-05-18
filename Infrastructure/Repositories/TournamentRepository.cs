
using Microsoft.EntityFrameworkCore;
using TournamentsApi.Domain.Models;

public class TournamentRepository(ApplicationDbContext applicationDbContext) : ITournamentRepository
{
    private readonly ApplicationDbContext _dbContext = applicationDbContext;

    public async Task<TournamentDTO> GetTournamentById(Guid tournamentId)
    {
        Tournament tournament = await _dbContext.Tournaments.FirstOrDefaultAsync(x => x.Id.Equals(tournamentId));

        return new TournamentDTO()
        {
            TournamentId = tournament.Id,
            TournamentName = tournament.Name,
            StartDate = tournament.StartDate,
            EndDate = tournament.EndDate
        };
    }

    public async Task<IEnumerable<Tournament>> GetAllTournaments()
    {
        return await _dbContext.Tournaments.ToListAsync();
    }

    public async Task<TournamentDTO> CreateTournament(string tournamentName, DateOnly startDate, DateOnly endDate)
    {
        Tournament tournament = new Tournament()
        {
            Name = tournamentName,
            StartDate = startDate,
            EndDate = endDate,
            Status = TournamentStatus.Scheduled.GetDescription()
        };

        _dbContext.Tournaments.Add(tournament);
        await _dbContext.SaveChangesAsync();

        return new TournamentDTO()
        {
            TournamentId = tournament.Id,
            TournamentName = tournamentName,
            StartDate = startDate,
            EndDate = endDate
        };
    }

    public async Task DeleteTournament(Guid tournamentId)
    {
        Tournament tournament = await _dbContext.Tournaments.FirstOrDefaultAsync(x => x.Id == tournamentId);

        if (tournament is null) return;
        
        _dbContext.Tournaments.Remove(tournament);

        await _dbContext.SaveChangesAsync();
    }
}