using System.ComponentModel.DataAnnotations;
using TournamentsApi.Domain.Models;

public class Round
{
    
    public Guid Id { get; set; }
    public Guid TournamentId { get; set; }
    public Tournament Tournament { get; set; } = default!;
    public int Number { get; set; }          // 1-4 (5+ para play-off)
    public DateOnly Date { get; set; }
    public bool IsCompleted { get; set; }

    public ICollection<Score> Scores { get; set; } = [];
}