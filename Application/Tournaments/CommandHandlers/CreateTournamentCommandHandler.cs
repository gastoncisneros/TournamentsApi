using MediatR;

public class CreateTournamentCommandHandler(ITournamentRepository tournamentRepository) : IRequestHandler<CreateTournamentCommand, TournamentDTO>
{
    private readonly ITournamentRepository _tournamentRepository = tournamentRepository;

    public async Task<TournamentDTO> Handle(CreateTournamentCommand request, CancellationToken cancellationToken)
    {
        return await _tournamentRepository.CreateTournament(request.TournamentName, request.StartDate, request.EndDate);
    }
}