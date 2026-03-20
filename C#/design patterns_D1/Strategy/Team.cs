using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public  class Team
    {
        TeamStrategy strategy;
        public Team(TeamStrategy _strategy) { 
          strategy = _strategy;
        }
        public void SetStrategy(TeamStrategy s) { 
         strategy = s;
        }

        public void PlayGame() {
            strategy.play();
        }
    }
}
