using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    internal class Duration
    {
        private int hours, minutes, seconds;

        public Duration(int h,int min, int _sec) {
            hours = h;
            minutes = min;
            seconds = _sec;
        
        }
        public Duration(int sec) {
            hours = sec / (60*60);
            minutes = (sec - (hours *60 * 60  )) /60 ;
            seconds = sec - (hours * 60 * 60) - (minutes * 60);
        }

        public int Hours
        {
            get { return hours; }
            set
            {
                if (value >= 0 && value < 24)
                    hours = value;
                else
                    hours = 0;
            }
        }

        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value >= 0 && value < 60)
                    minutes = value;
                else
                    minutes = 0;
            }
        }

        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value >= 0 && value < 60)
                    seconds = value;
                else
                    seconds = 0;
            }
        }
        public override string ToString()
        {
            if (Hours > 0)
            {
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            }
            else if (Minutes > 0)
            {
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            }
            else
            {
                return $"Seconds: {Seconds}";
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Duration d)
            {
                return Hours == d.Hours && Minutes == d.Minutes && Seconds == d.Seconds;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return ToTotalSeconds();
        }


        private int ToTotalSeconds()
        {
            return (hours * 3600) + (minutes * 60) + seconds;
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.ToTotalSeconds() + d2.ToTotalSeconds());
        }

        public static Duration operator +(Duration d1, int sec)
        {
            return new Duration(d1.ToTotalSeconds() + sec);
        }

        public static Duration operator +(int sec, Duration d1)
        {
            return new Duration(sec + d1.ToTotalSeconds());
        }

        public static Duration operator -(Duration d)
        {
            return new Duration(-d.ToTotalSeconds());
        }
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() > d2.ToTotalSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() < d2.ToTotalSeconds();
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() >= d2.ToTotalSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() <= d2.ToTotalSeconds();
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.ToTotalSeconds() + 60);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(d.ToTotalSeconds() - 60);
        }

        public static bool operator true(Duration d)
        {
            return d.ToTotalSeconds() > 0;
        }

        public static bool operator false(Duration d)
        {
            return d.ToTotalSeconds() <= 0;
        }


        public static explicit operator DateTime(Duration d)
        {
            return new  DateTime(1, 1, 1, d.Hours , d.Minutes, d.Seconds);
        }




    }
}