using MediatR;

public class GetTournamentByIdQuery : IRequest<TournamentDTO>
{
    public Guid TournamentId { get; set; }
}