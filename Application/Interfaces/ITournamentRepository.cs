using TournamentsApi.Domain.Models;

public interface ITournamentRepository
{
    Task<TournamentDTO> GetTournamentById(Guid tournamentId);
    Task<IEnumerable<Tournament>> GetAllTournaments();
    Task<TournamentDTO> CreateTournament(string tournamentName, DateOnly startDate, DateOnly endDate);
    Task DeleteTournament(Guid tournamentId);
}