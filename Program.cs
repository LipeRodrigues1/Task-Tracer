using Task_Tracer;

var taskService = new TaskService();

if (args.Length == 0)
{
    ShowHelp();
    return;
}

var command = args[0].ToLower();

switch (command)
{
    case "add":
        if (args.Length < 2)
        {
            Console.WriteLine("Please provide a title for the task");
            return;
        }
        var title = string.Join(' ', args.Skip(1));
        taskService.AddTask(title);
        Console.WriteLine("Task added successfully");
        break;

    case "list":
        taskService.ListTasks();
        break;

    case "update":
        if (args.Length < 3)
        {
            Console.WriteLine("Please provide the task ID and new status");
            return;
        }
        var taskId = int.Parse(args[1]);
        var newStatus = Enum.Parse<Task_Tracer.TaskStatus>(args[2], true);
        taskService.UpdateTask(taskId, newStatus);
        Console.WriteLine("Task updated successfully");
        break;
    case "mark-done":
        if (args.Length < 2)
        {
            Console.WriteLine("Please provide the task ID");
            return;
        }
        var doneTaskId = int.Parse(args[1]);
        taskService.UpdateTask(doneTaskId, Task_Tracer.TaskStatus.Done);
        Console.WriteLine("Task marked as done successfully");
        break;
    case "mark-in-progress":
        if (args.Length < 2)
        {
            Console.WriteLine("Please, Provide the task ID");
            return;
        }
        var IdTask = int.Parse(args[1]);
        taskService.UpdateTask(IdTask, Task_Tracer.TaskStatus.InProgress);
        Console.WriteLine("Task marked as in progress successfully");
        break;

    case "delete":
        if (args.Length< 2)
        {
            Console.WriteLine("Please, provide the task ID");
            return;
        }
        var deleteTaskId = int.Parse(args[1]);
        taskService.DeleteTask(deleteTaskId);
        Console.WriteLine("Task deleted successfully");
        break;

    default:
        Console.WriteLine("Unknown command");
        break;
}
static void ShowHelp()
{
    Console.WriteLine("Task Tracker CLI");
    Console.WriteLine("-------------------------");
    Console.WriteLine("Commands:");
    Console.WriteLine("add \"task title\"");
    Console.WriteLine("list");
    Console.WriteLine("update <id> <Todo|InProgress|Done>");
    Console.WriteLine("mark-in-progress <id>");
    Console.WriteLine("mark-done <id>");
    Console.WriteLine("delete <id>");
    Console.WriteLine("help");
}
