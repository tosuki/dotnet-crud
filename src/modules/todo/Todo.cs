namespace TodoModule
{
  class Todo
  {
    public string? id {get; set;}
    public string? Title {get; set;}
    public string? Description {get; set;}
    public TodoStatus Status { get; set; } = TodoStatus.Pending;

    public override string ToString()
    {
      return $"[{id}] {Title} - {Description} (Status: {Status})";
    }
  }
}
