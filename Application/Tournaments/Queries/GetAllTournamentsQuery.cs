using MediatR;
using TournamentsApi.Domain.Models;

public class GetAllTournamentsQuery : IRequest<IEnumerable<Tournament>>
{
    
}