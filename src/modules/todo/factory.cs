using Microsoft.EntityFrameworkCore;

namespace TodoModule
{
  class TodoFactory
  {
    public static ITodoRepository CreateTodoRepository()
    {
      return new InMemoryTodoRepository(new DbContextOptionsBuilder<InMemoryTodoRepository>()
        .UseInMemoryDatabase("Todos")
        .Options
      );
    }

    public static TodoUsecase CreateTodoUsecase()
    {
      var repository = CreateTodoRepository();
      return new TodoUsecase(repository);
    }
  }
}