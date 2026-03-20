using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Football :Ball
    {
        private Position _myPosition;

        public Football(Position p) { 
         
            _myPosition = p;
         
        }
        public Position GetBallPosition()
        {
            return _myPosition;
        }

        public void SetBallPosition(Position p)
        {
            _myPosition = p;
            NotifyObservers();
        }


    }

    public class Player : IObserver
    {
        Position BallPosition;
         Football _ball;
        public Player(Football ball)
        {
            _ball = ball;
        }
        public void Update()
        {
            BallPosition = _ball.GetBallPosition();
            Console.WriteLine(" player : "+BallPosition);
        }
    }

    public class Referee : IObserver
    {
        private Football _ball;
        private Position _ballPosition;

        public Referee(Football ball)
        {
            _ball = ball;
        }

        public void Update()
        {
            _ballPosition = _ball.GetBallPosition();
            Console.WriteLine(" Referee : " + _ballPosition);
        }
    }

}
