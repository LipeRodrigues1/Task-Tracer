namespace Task_Tracer;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public TaskStatus Status { get; set; }
    public DateTime CreatedAt{ get; set; }

    public TaskItem(int id, string title)
    {
        Id = id;
        Title = title;
        Status = TaskStatus.InProgress;
        CreatedAt = DateTime.Now;
    }
}
