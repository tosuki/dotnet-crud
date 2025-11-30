namespace TodoModule
{
  interface ITodoRepository
  {
    Todo? Save();
    Todo? GetById(string id);
    Todo? DeleteById(string id);
    Todo? ChangeStatusById(string id, TodoStatus status);
  }
}