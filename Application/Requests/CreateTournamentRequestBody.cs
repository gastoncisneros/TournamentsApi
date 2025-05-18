public class CreateTournamentRequestBody
{
    public string TournamentName { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
}