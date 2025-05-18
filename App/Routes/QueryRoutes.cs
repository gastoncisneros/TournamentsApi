using MediatR;
using Microsoft.AspNetCore.Mvc;
using TournamentsApi.Domain.Models;

public static class QueryRoutes
{
    public static void MapQueryRoutes(this WebApplication application)
    {
        RouteGroupBuilder basePath = application.MapGroup("/api/tournaments");

        basePath.MapGet("/{tournamentId}", async (IMediator mediator, [FromRoute] string tournamentId) =>
        {
            Guid idGuid = Guid.Parse(tournamentId);
            GetTournamentByIdQuery query = new GetTournamentByIdQuery() { TournamentId = idGuid };
            TournamentDTO tournament = await mediator.Send(query);

            return TypedResults.Ok(tournament);
        })
        .WithName("GetTournamentById");

        basePath.MapGet("/", async (IMediator mediator) => 
        {
            GetAllTournamentsQuery query = new GetAllTournamentsQuery();
            IEnumerable<Tournament> tournaments = await mediator.Send(query);

            return TypedResults.Ok(tournaments);
        })
        .WithName("GetAllTournaments");
    }
}