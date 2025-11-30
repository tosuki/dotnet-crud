namespace ApplicationHttpServer
{
  class ApplicationOptions
  {
    public string Url { get; set; } = "";
  }
  
  class ApplicationServer
  {
    private ApplicationOptions options;
    private WebApplication webApplication;

    public ApplicationServer(ApplicationOptions options)
    {
      this.options = options;
      webApplication = WebApplication.CreateBuilder().Build();
    }

    private void registerRoutes() {}

    public void StartServer()
    {
      registerRoutes();
      webApplication.Run(options.Url.Length >= 1 ? options.Url : "http://localhost:3333");
    }
  }
}