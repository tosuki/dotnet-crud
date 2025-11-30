namespace TodoModule
{
  interface ITodoRepository
  {
    Task<Todo> Save(Todo todo);
    Task<Todo?> GetById(string id);
    Task<Todo?> DeleteById(string id);
    Task<Todo?> ChangeStatusById(string id, TodoStatus status);
    Task<List<Todo>> GetAll();
  }
}