namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new FieldPlayer();

            MidFielder midRole = new MidFielder();
            midRole.AssignPlayer(player1);

            Forward forwardRole = new Forward();
            forwardRole.AssignPlayer(midRole);

            Console.WriteLine("--- Testing Field Player with Multiple Roles ---");
            forwardRole.PassBall();

            Console.WriteLine("\n--- Testing GoalKeeper with Defense Role ---");
            Player keeper = new GoalKeeper();
            Defender defRole = new Defender();
            defRole.AssignPlayer(keeper);
            defRole.PassBall();
        }
    }
}
