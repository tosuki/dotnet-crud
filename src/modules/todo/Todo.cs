namespace TodoModule
{
  class Todo
  {
    public string? id {get; set;}
    public string? Title {get; set;}
    public string? Description {get; set;}
    public TodoStatus status { get; set; } = TodoStatus.Pending;
  }
}
