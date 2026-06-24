class TaskNode
{
    public int TaskId;
    public string TaskName;
    public string Status;
    public TaskNode Next;

    public TaskNode(int id, string name, string status)
    {
        TaskId = id;
        TaskName = name;
        Status = status;
        Next = null;
    }
}

class TaskManagement
{
    private TaskNode head = null;

    public void AddTask(int id, string name, string status)
    {
        TaskNode newTask = new TaskNode(id, name, status);

        if (head == null)
        {
            head = newTask;
        }
        else
        {
            TaskNode current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newTask;
        }

        Console.WriteLine("Task added successfully.");
    }

    public void SearchTask(int taskId)
    {
        TaskNode current = head;

        while (current != null)
        {
            if (current.TaskId == taskId)
            {
                Console.WriteLine(
                    current.TaskId + " " +
                    current.TaskName + " " +
                    current.Status
                );
                return;
            }

            current = current.Next;
        }

        Console.WriteLine("Task not found.");
    }

    public void TraverseTasks()
    {
        TaskNode current = head;

        while (current != null)
        {
            Console.WriteLine(
                current.TaskId + " " +
                current.TaskName + " " +
                current.Status
            );

            current = current.Next;
        }
    }

    public void DeleteTask(int taskId)
    {
        if (head == null)
        {
            Console.WriteLine("Task list is empty.");
            return;
        }

        if (head.TaskId == taskId)
        {
            head = head.Next;
            Console.WriteLine("Task deleted successfully.");
            return;
        }

        TaskNode current = head;

        while (current.Next != null)
        {
            if (current.Next.TaskId == taskId)
            {
                current.Next = current.Next.Next;
                Console.WriteLine("Task deleted successfully.");
                return;
            }

            current = current.Next;
        }

        Console.WriteLine("Task not found.");
    }
}

class Program
{
    static void Main()
    {
        TaskManagement management = new TaskManagement();

        management.AddTask(1, "Design UI", "Pending");
        management.AddTask(2, "Write Code", "In Progress");
        management.AddTask(3, "Test Application", "Pending");

        Console.WriteLine("\nAll Tasks:");
        management.TraverseTasks();

        Console.WriteLine("\nSearch Task with ID 2:");
        management.SearchTask(2);

        management.DeleteTask(2);

        Console.WriteLine("\nAfter Deleting Task with ID 2:");
        management.TraverseTasks();
    }
}