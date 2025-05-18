using MediatR;
using TournamentsApi.Domain.Models;

public class GetAllTournamentsQueryHandler(ITournamentRepository tournamentRepository) : IRequestHandler<GetAllTournamentsQuery, IEnumerable<Tournament>>
{
    private readonly ITournamentRepository _tournamentRepository = tournamentRepository;

    public async Task<IEnumerable<Tournament>> Handle(GetAllTournamentsQuery request, CancellationToken cancellationToken)
    {
        return await _tournamentRepository.GetAllTournaments();
    }
}