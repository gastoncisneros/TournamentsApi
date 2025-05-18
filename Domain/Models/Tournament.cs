namespace TournamentsApi.Domain.Models;

public class Tournament
{
    public Guid Id { get; set; } = new Guid();
    public string Name { get; set; } = default!;
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate   { get; set; }
    public string Status { get; set; } = "";
    public int Par { get; set; }
    public string CutRule { get; set; } = "";

    public ICollection<Round> Rounds { get; set; } = [];
    public ICollection<TournamentPlayer> TournamentPlayers { get; set; } = [];
}