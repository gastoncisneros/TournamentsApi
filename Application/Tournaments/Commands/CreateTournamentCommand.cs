using MediatR;

public class CreateTournamentCommand : IRequest<TournamentDTO>
{
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public string TournamentName { get; set; }
}