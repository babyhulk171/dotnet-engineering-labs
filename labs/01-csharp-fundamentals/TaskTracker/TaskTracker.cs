enum TaskStatus
{
    Todo,
    InProgress,
    Done
};

record TaskItem(string title, TaskStatus status);

class TaskTracker
{
    static void Main()
    {
        var rand = new Random();
        Array values = Enum.GetValues(typeof(TaskStatus));
        List <TaskItem> tasks = new List<TaskItem>(10);

        for (int i = 0; i < 10; i++)
        {
            TaskStatus task = (TaskStatus)values.GetValue(rand.Next(values.Length));
            tasks.Add(new TaskItem(i.ToString() ,task));
        }

        foreach (TaskItem t in tasks)
        {
            if (t.status == TaskStatus.Done)
            {
                Console.WriteLine(t.title);
                Console.WriteLine(t.status);   
            }

        }
    }
}