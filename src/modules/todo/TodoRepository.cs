using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TodoModule
{
  class InMemoryTodoRepository : DbContext, ITodoRepository
  {
    public InMemoryTodoRepository(DbContextOptions<InMemoryTodoRepository> options) : base(options)
    {}
    public DbSet<Todo> Todos => Set<Todo>();

    public async Task<Todo?> ChangeStatusById(string id, TodoStatus status)
    {
      var todo = await Todos.FirstOrDefaultAsync(t => t.id == id);
      
      if (todo != null)
      {
        todo.Status = status;
        await SaveChangesAsync();
      }

      return todo;
    }

    public async Task<Todo?> DeleteById(string id)
    {
      var todo = await Todos.FirstOrDefaultAsync(t => t.id == id);
      
      if (todo != null)
      {
        Todos.Remove(todo);
        await SaveChangesAsync();
      }

      return todo;
    }

    public async Task<Todo?> GetById(string id)
    {
      return await Todos.FirstOrDefaultAsync(t => t.id == id);
    }

    public async Task<Todo?> Save(Todo todo)
    {
      Todos.Add(todo);
      await SaveChangesAsync();
      return todo;
    }

    public async Task<List<Todo>> GetAll()
    {
      return await Todos.ToListAsync();
    }
  }
}