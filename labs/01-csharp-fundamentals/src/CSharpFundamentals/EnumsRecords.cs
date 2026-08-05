namespace CSharpFundamentals
{
    enum EnemyState
    {
        SEEKING,
        ATTACKING,
        RUNNIN,
        THINKING
    }
    public class EnumsRecords
    {
        public static void Run()
        {
            var currentState = EnemyState.THINKING;
            if (currentState == EnemyState.THINKING) Console.WriteLine("the enemy is thinking.");
        }
    }
}