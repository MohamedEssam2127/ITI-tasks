using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{

    public abstract class Player
    {
        public abstract void PassBall();
    }

    public class FieldPlayer : Player
    {
        public override void PassBall()
        {
            Console.WriteLine("Field Player passes the ball.");
        }
    }

    public class GoalKeeper : Player
    {
        public override void PassBall()
        {
            Console.WriteLine("GoalKeeper passes the ball.");
        }
    }

    public abstract class PlayerRole : Player
    {
        protected Player _player;

        public void AssignPlayer(Player p)
        {
            _player = p;
        }

        public override void PassBall()
        {
            if (_player != null)
            {
                _player.PassBall();
            }
        }
    }

    public class Forward : PlayerRole
    {
        public override void PassBall()
        {
            base.PassBall();
            ShootGoal();
        }

        public void ShootGoal()
        {
            Console.WriteLine("Forward ");
        }
    }

    public class MidFielder : PlayerRole
    {
        public override void PassBall()
        {
            base.PassBall();
            Dribble();
        }

        public void Dribble()
        {
            Console.WriteLine("MidFielder ");
        }
    }

    public class Defender : PlayerRole
    {
        public override void PassBall()
        {
            base.PassBall();
            Defend();
        }

        public void Defend()
        {
            Console.WriteLine("Defender ");
        }
    }



}
