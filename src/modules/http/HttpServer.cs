using Microsoft.Extensions.Options;
using TodoModule;

namespace ApplicationHttpServer
{
  class ApplicationServerOptions
  {
    public int Port { get; set; } = 8080;
    public string HostName { get; set; } = "localhost";
  }

  class ApplicationServer
  {
    private TodoUsecase todoUsecase { get; set; }
    private WebApplication webApplication { get; set; }
    private ApplicationServerOptions options { get; set; }

    public ApplicationServer(TodoUsecase todoUsecase)
    {
      this.todoUsecase = todoUsecase;
      this.options = new ApplicationServerOptions();
      webApplication = WebApplication.CreateBuilder().Build();
    }

    public ApplicationServer(TodoUsecase todoUsecase, ApplicationServerOptions options)
    {
      this.todoUsecase = todoUsecase;
      this.options = options;
      webApplication = WebApplication.CreateBuilder().Build();
    }


    public void Start()
    {
      ApplicationRouter.ConfigureRoutes(webApplication, todoUsecase);
      webApplication.Run($"http://{options.HostName}:{options.Port}");
    }
  }
}