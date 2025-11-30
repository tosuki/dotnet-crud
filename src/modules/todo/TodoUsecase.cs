namespace TodoModule
{
  class TodoUsecase
  {
    private ITodoRepository todoRepository;

    public TodoUsecase(ITodoRepository todoRepository)
    {
      this.todoRepository = todoRepository;
    }
  
    public async Task<Todo> Create(string title, string description)
    {
      Todo todo = new Todo
      {
        id = Guid.NewGuid().ToString(),
        Title = title,
        Description = description,
        Status = TodoStatus.Pending
      };

      await todoRepository.Save(todo);

      return todo;
    }

    public Task<Todo?> GetById(string id)
    {
      return todoRepository.GetById(id);
    }

    public Task<Todo?> DeleteById(string id)
    {
      return todoRepository.DeleteById(id);
    }

    public Task<List<Todo>> GetAll()
    {
      return todoRepository.GetAll();
    }
  }
}