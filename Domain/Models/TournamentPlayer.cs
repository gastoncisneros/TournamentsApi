using System.ComponentModel.DataAnnotations;
using TournamentsApi.Domain.Models;

public class TournamentPlayer          // tabla puente N-a-N
{
    
    public Guid TournamentId { get; set; }
    
    public Tournament Tournament { get; set; } = default!;
    
    
    public Guid PlayerId { get; set; }

    public Player Player { get; set; } = default!;

    public TimeOnly? TeeTime { get; set; }

    public int? StartingHole { get; set; }   // 1 ó 10

    public bool IsAmateur { get; set; }

    public bool IsCut { get; set; }      // queda fuera tras el corte

    public string Status { get; set; } = "Active";   // Active | WD | DQ

    public ICollection<Score> Scores { get; set; } = [];
}