using MediatR;

public class DeleteTournamentCommandHandler(ITournamentRepository tournamentRepository) : IRequestHandler<DeleteTournamentCommand>
{
    private readonly ITournamentRepository _tournamentRepository = tournamentRepository;

    public async Task Handle(DeleteTournamentCommand request, CancellationToken cancellationToken)
    {
        await _tournamentRepository.DeleteTournament(request.TournamentId);
    }
}