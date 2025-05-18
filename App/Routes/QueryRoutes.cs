public static class QueryRoutes
{
    public static void MapQueryRoutes(this WebApplication application)
    {
        RouteGroupBuilder basePath = application.MapGroup("/api/tournaments");
    }
}