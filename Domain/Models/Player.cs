public class Player
{
    public Guid Id { get; set; }
    public string? OfficialId { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName  { get; set; } = default!;
    public string Country   { get; set; } = default!;   // ISO-3
    public int?   WorldRanking { get; set; }

    public IEnumerable<TournamentPlayer> TournamentPlayers { get; set; } = [];
}