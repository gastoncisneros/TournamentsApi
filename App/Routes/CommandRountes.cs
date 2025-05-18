using MediatR;
using Microsoft.AspNetCore.Mvc;
using TournamentsApi.Domain.Models;

public static class CommandRountes
{
    public static void MapCommandRoutes(this WebApplication application)
    {
        RouteGroupBuilder basePath = application.MapGroup("/api/tournaments");

        basePath.MapPost("/", async (IMediator mediator, [FromBody] CreateTournamentRequestBody tournament) =>
        {
            CreateTournamentCommand createTournamentCommand = new CreateTournamentCommand()
            {
                TournamentName = tournament.TournamentName,
                StartDate = tournament.StartDate,
                EndDate = tournament.EndDate
            };

            TournamentDTO tournamentDTO = await mediator.Send(createTournamentCommand);

            return Results.CreatedAtRoute("GetTournamentById", new {tournamentDTO.TournamentId}, tournamentDTO);
        });

        basePath.MapDelete("/{id}", async (IMediator mediator, [FromRoute] Guid id) =>
        {
            DeleteTournamentCommand command = new DeleteTournamentCommand(){TournamentId = id};
            await mediator.Send(command);
            return Results.NoContent();
        });
    }
}