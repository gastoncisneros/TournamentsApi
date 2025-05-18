public static class CommandRountes
{
    public static void MapCommandRoutes(this WebApplication application)
    {
        RouteGroupBuilder basePath = application.MapGroup("/api/tournaments");
    }
}