using TodoModule;

namespace ApplicationHttpServer
{
  class TodoController
  {
    private TodoUsecase todoUsecase { get; set;}
    
    public TodoController(TodoUsecase todoUsecase)
    {
      this.todoUsecase = todoUsecase;
    }

    public async Task<HttpResponseModel<List<Todo>>> GetAllTodos()
    {
      var result = await todoUsecase.GetAll();

      return new HttpResponseModel<List<Todo>>()
      {
        Ok = true,
        Data = result,
        Message = "Fetched all todos successfully"
      };
    }
  }
}