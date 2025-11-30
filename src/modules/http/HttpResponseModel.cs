namespace ApplicationHttpServer
{
  class HttpResponseModel <T>
  {
    public bool Ok { get; set; } = true;
    public T? Data { get; set; }
    public String? Message { get; set; }

  }
}