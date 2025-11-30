using TodoModule;

namespace ApplicationHttpServer
{
  class ApplicationRouter
  {
    public static void ConfigureRoutes(WebApplication app, TodoUsecase todoUsecase)
    {
      app.MapGet("/ok", () => new { ok = true, message = "Pong!"});
      app.MapGet("/all", async () => await todoUsecase.GetAll());
    }
  }
}