public class PredictionHistory
{
    public Guid Id { get; set; }
    public Guid PredictionId { get; set; }
    public int PointsEarned { get; set; }
    public DateTime CalculatedOn { get; set;}
}