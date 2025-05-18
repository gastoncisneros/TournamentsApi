namespace TournamentsApi.Domain.Models;

public class Tournament
{
    public int Id   { get; set; }
    public string Name { get; set; } = default!;
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate   { get; set; }
    public string Status { get; set; } = "Scheduled";   // Scheduled | Ongoing | Finished
    public int Par { get; set; } = 72;
    public string CutRule { get; set; } = "Top 70 & ties";

    public ICollection<Round> Rounds { get; set; } = [];
    public ICollection<TournamentPlayer> TournamentPlayers { get; set; } = [];
}