namespace CSharpFundamentals
{
    enum EnemyState
    {
        Seeking,
        Atacking,
        Running,
        Thinking
    }
    public class EnumsRecords
    {
        public static void Run()
        {
            var currentState = EnemyState.Thinking;
            if (currentState == EnemyState.Thinking) Console.WriteLine("the enemy is thinking.");

            // Records vs Class: 
        }
    }
}