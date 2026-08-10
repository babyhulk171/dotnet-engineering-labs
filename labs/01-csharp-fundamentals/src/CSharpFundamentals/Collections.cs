namespace CSharpFundamentals
{
    public class Collections
    {
        private List<int> taskIds = new List<int>();
        private Dictionary<int, string> tasks = new Dictionary<int, string>{};
        private HashSet<string> usernames = new HashSet<string>();
        private Queue<int> taskPriority = new Queue<int>();
        private Stack<int> mostImportantTasks = new Stack<int>();

        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                taskIds.Add(i);
                tasks.TryAdd(i, "task"+i.ToString());
                taskPriority.Enqueue(i);
            }
            mostImportantTasks.Push(9); // Most important after 1
            mostImportantTasks.Push(1); // Should be the most important for now, use LIFO

            Console.WriteLine(usernames.Add("pablo")); // succesfully add user and returns true
            Console.WriteLine(usernames.Add("pablo")); // can't add user because it already exists, return false

            Console.WriteLine(tasks[mostImportantTasks.Peek()]); // get the id from the queue and show the most important task using the task dictionary

            foreach (int t in taskPriority) // prints the task based on the priority using FIFO
            {
                Console.WriteLine(tasks[t]);
            }
        }
    }
}