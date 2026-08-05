namespace CSharpFundamentals
{
    enum EnemyState
    {
        Seeking,
        Attacking,
        Running,
        Thinking
    }
    public class EnumsRecords
    {
        public static void Run()
        {
            var currentState = EnemyState.Thinking;
            if (currentState == EnemyState.Thinking) Console.WriteLine("the enemy is thinking.");

            // Records vs Class
            var first = new PersonRecord("Jessica", 23);
            var second = new PersonRecord("Jessica", 23);

            Console.WriteLine(first == second);
            Console.WriteLine(ReferenceEquals(first, second));
        }
    }
}