using System.ComponentModel.DataAnnotations;

public class PredictionPick
{
    
    public Guid PredictionId { get; set; }

    
    public Guid PlayerId { get; set; }
    
    public int Position { get; set; }
}