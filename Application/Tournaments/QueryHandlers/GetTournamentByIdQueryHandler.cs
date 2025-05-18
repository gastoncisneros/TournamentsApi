using MediatR;

public class GetTournamentByIdQueryHandler(ITournamentRepository tournamentRepository) : IRequestHandler<GetTournamentByIdQuery, TournamentDTO>
{
    private readonly ITournamentRepository _tournamentRepository = tournamentRepository;

    public async Task<TournamentDTO> Handle(GetTournamentByIdQuery request, CancellationToken cancellationToken)
    {
        TournamentDTO tournamentDTO = await _tournamentRepository.GetTournamentById(request.TournamentId);

        return tournamentDTO;
    }
}