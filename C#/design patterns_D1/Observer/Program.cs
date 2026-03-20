namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Football f = new Football(new Position(2,2,2));
            Player p1 = new Player(f);
            Player p2 = new Player(f);
            Referee r = new Referee(f);
            f.AttachObserver(p1);
            f.AttachObserver(p2);
            f.AttachObserver(r);
            f.SetBallPosition(new Position(5, 5, 5));

        }
    }
}
