using TodoModule;

TodoUsecase todoUsecase = TodoFactory.CreateTodoUsecase();

try
{
  Todo createdTodo = await todoUsecase.Create("Sample Todo", "This is a sample todo item.");
  Console.WriteLine($"Created Todo: {createdTodo.id}, Title: {createdTodo.Title}");

  List<Todo> allTodos = await todoUsecase.GetAll();

  Console.WriteLine($"All Todos:\n- {string.Join("\n- ", allTodos)}");
} catch (Exception exception)
{
  Console.WriteLine($"Error creating todo: {exception.Message}");
}
