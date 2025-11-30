namespace TodoModule
{
  class TodoUsecase
  {
    private ITodoRepository todoRepository;

    public TodoUsecase(ITodoRepository todoRepository)
    {
      this.todoRepository = todoRepository;
    }

    public Todo? Create(string title, string description)
    {
      throw new Exception("Feature not implemented yet");
    }
  }
}