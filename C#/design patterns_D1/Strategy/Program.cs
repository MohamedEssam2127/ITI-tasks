namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team myTeam = new Team(new AttackStrategy());

            myTeam.PlayGame();

            myTeam.SetStrategy(new DefendStrategy());
            myTeam.PlayGame();
        }
    }
}
