using System;
using System.Collections.Generic;
using System.Text;

namespace Review
{
    public class Alarm
    {

        /// <summary>
        /// 1 create event 
        /// </summary>
        public event  EventHandler <RingEventArgs > Ring ;


        public void setNewAlarm(int t , string message ) {
            RingEventArgs e = new RingEventArgs( t, message);
            OnProcessCompleted(e);
        
        }
        /// <summary>
        /// invoke function 
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnProcessCompleted(RingEventArgs e)
        {
            Ring?.Invoke(this, e);
        }
    }


    public class Watch {

        
        public void Display(object sender  , RingEventArgs e  ) {

            Console.WriteLine($" Ring at time {e.Time}  say  {e.message}");
        }
    
    }

    public class RingEventArgs  : EventArgs{

        public int Time;
        public string message; 

         public  RingEventArgs(int time, string message)
        {
            Time = time;
            this.message = message;
        }
    }
}
