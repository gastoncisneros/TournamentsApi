
using System.ComponentModel.DataAnnotations;

public class Score
{
    public Guid Id { get; set; } = new Guid();
    
    
    public Guid RoundId { get; set; }

    
    public Guid PlayerId { get; set; }

    public int Strokes { get; set; }

    public int ScoreToPar { get; set; }
}