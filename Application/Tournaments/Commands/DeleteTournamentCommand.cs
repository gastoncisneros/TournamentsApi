using MediatR;

public class DeleteTournamentCommand : IRequest
{
    public Guid TournamentId { get; set; }
}