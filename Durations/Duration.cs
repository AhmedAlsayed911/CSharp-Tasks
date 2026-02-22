using System;
using System.Collections.Generic;
using System.Text;

namespace Durations
{
    internal class Duration
    {
        public int Hours {  get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }

        public Duration(int hours, int minutes, int seconds)
        {
            int totalSeconds = (hours * 60 * 60) + (minutes * 60) + seconds;

            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;

            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }

        public Duration(int seconds)
        {
            Hours = seconds / 3600;
            seconds %= 3600;

            Minutes = seconds / 60;
            Seconds = seconds % 60;
        }
        public override string ToString()
        {
            return $"Hours: {Hours},Minutes:{Minutes}:Seconds:{Seconds}";
        }

        public override bool Equals(object? obj)
        {
            if(obj is not null && obj is Duration)
            {
                Duration ?other = obj as Duration;
                return other.Hours == Hours && other.Minutes == Minutes && other.Seconds == Seconds ;
            }
            return false ;
        }

        public static Duration operator+(Duration d1 , Duration d2)
        {
            return new Duration(d1.Hours + d2.Hours , d1.Minutes + d1.Minutes , d1.Seconds + d2.Seconds);
        }

        public static Duration operator +(Duration d1, int d)
        {
            return new Duration(d1.Hours, d1.Minutes , d1.Seconds + d);
        }

        public static Duration operator +(int d , Duration d1)
        {
            return d1 + d;
        }
        public static Duration operator ++(Duration d1)
        {
            return new Duration(d1.Hours, d1.Minutes + 1, d1.Seconds);
        }
        public static Duration operator --(Duration d1)
        {
            return new Duration(d1.Hours, d1.Minutes - 1, d1.Seconds);
        }

        public static bool operator >(Duration d1 , Duration d2)
        {
            if (d1.Hours > d2.Hours)
                return true;
            else if(d1.Hours == d2.Hours)
            {
                if(d1.Minutes > d2.Minutes)
                    return true;
                else if(d1.Minutes == d2.Minutes)
                {
                    if (d1.Seconds > d2.Seconds)
                        return true;
                    else if (d1.Seconds == d2.Seconds)
                        return false;
                }
            }
            return false;
        }
        public static bool operator <(Duration d1 , Duration d2)
        {
            return d2 > d1;
        }

        public static explicit operator DateTime(Duration d)
        {
            var dt = new DateTime();
            
            dt.AddHours(d.Hours);
            dt.AddMinutes(d.Minutes);
            dt.AddSeconds(d.Seconds);
            return dt;
        }
    }
}
