public class Prediction
{
    public Guid Id { get; set; }
    public Guid TournamentId { get; set; }
    public Guid UserId { get; set; }
    public DateTime CreatedOn { get; set; }
    public ICollection<PredictionPick> Picks { get; set; } = [];
}