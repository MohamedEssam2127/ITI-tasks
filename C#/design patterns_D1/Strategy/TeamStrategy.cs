using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public abstract class TeamStrategy
    {
        public abstract void play();
    }

    public class AttackStrategy : TeamStrategy {

        public override void play()
        {
            Console.WriteLine("Team is now in Attack mode ");
        }
    }

    public class DefendStrategy : TeamStrategy
    {

        public override void play()
        {
            Console.WriteLine("Team is now in Defend mode ");
        }
    }
}
