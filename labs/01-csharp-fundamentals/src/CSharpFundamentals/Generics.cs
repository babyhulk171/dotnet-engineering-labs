namespace CSharpFundamentals
{
    public interface ITask
    {
        int Id { get; set; }
        string TaskDescription { get; set; }
    }

    public class Task : ITask
    {
        public int Id { get; set; }
        public string TaskDescription { get; set; }

        public Task(int id, string description)
        {
            Id = id;
            TaskDescription = description;
        }
    }

    public class EventTask : ITask
    {
        public int Id { get; set; }
        public string TaskDescription { get; set; }

        public EventTask(int id, string description)
        {
            Id = id;
            TaskDescription = description;
        }
    }

    public class ShowTaskDescription<T> where T : ITask // Only accept classes that implement ITask
    {
        public void Show(T task)
        {
            Console.WriteLine(task.TaskDescription);
        }
    }

    public class Generics
    {
        public static void PrintAnything<T>(T text)
        {
            Console.WriteLine(text);
        }

        public static void Run()
        {
            Task t = new Task(0, "test task");
            EventTask et = new EventTask(0, "test event task");
            ShowTaskDescription<Task> d = new ShowTaskDescription<Task>();
            ShowTaskDescription<EventTask> ed = new ShowTaskDescription<EventTask>();
            d.Show(t);
            ed.Show(et);

            PrintAnything(4);
            PrintAnything("four");
        }
    }
}