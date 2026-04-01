namespace Task_Tracer;

using System.ComponentModel;
using System.Text.Json;

public class TaskService
{
    private string filepath = "tasks.json";

    public List<TaskItem> GetAllTasks()
    {
        if (!File.Exists(filepath))
        {
            return new List<TaskItem>();
        }

        string json = File.ReadAllText(filepath);

        if (string.IsNullOrEmpty(json))
        {
            return new List<TaskItem>();
        }

        var tasks = JsonSerializer.Deserialize<List<TaskItem>>(json);
        return tasks ?? new List<TaskItem>();
    }
    public void SaveTasks(List<TaskItem> tasks)
    {
        string json = JsonSerializer.Serialize(tasks);

        File.WriteAllText(filepath, json);
    }

    public void AddTask(string title)
    {
        var tasks = GetAllTasks();

        int newId = tasks.Count > 0 ? tasks.Max(t => t.Id) + 1 : 1;

        var newTask = new TaskItem(newId, title);

        tasks.Add(newTask);
        SaveTasks(tasks);
    } 
    public void ListTasks()
    {
        var tasks = GetAllTasks();
        if(tasks.Count == 0)
        {
            System.Console.WriteLine("No tasks found.");
            return;
        }
        foreach (var task in tasks)
        {
            System.Console.WriteLine($"ID: {task.Id}, Title: {task.Title}, Status: {task.Status}, Created At: {task.CreatedAt:dd/MM/yyyy HH:mm:ss}");
        }
    }
    public void DeleteTask(int id)
    {
        var tasks = GetAllTasks();
        var task = tasks.FirstOrDefault(t => t.Id == id);

        if (task == null)
        {
            System.Console.WriteLine("Task not found");
            return;
        }

        tasks.Remove(task);
        SaveTasks(tasks);
        System.Console.WriteLine("Task deleted successfully");
    }

    public void UpdateTask(int id, TaskStatus taskStatus)
    {
        var tasks = GetAllTasks();
        var task = tasks.FirstOrDefault(t => t.Id == id);

        if (task == null)
        {
            System.Console.WriteLine("Task not found");
            return;
        }

        task.Status = taskStatus;
        SaveTasks(tasks);
        System.Console.WriteLine("Task status updated successfully");

    }

    
}
