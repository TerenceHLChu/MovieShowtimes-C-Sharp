using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieShowtimes
{
    public struct Time
    {
        public int Hours { get; }
        public int Minutes { get; }

        public Time (int hours, int minutes = 0)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}";
        }

        public static bool operator == (Time lhs, Time rhs)
        {
            int lhsMinutes = (lhs.Hours * 60) + lhs.Minutes;
            int rhsMinutes = (rhs.Hours * 60) + rhs.Minutes;

            if (Math.Abs(rhsMinutes - lhsMinutes) < 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (Time lhs, Time rhs)
        {
            int lhsMinutes = (lhs.Hours * 60) + lhs.Minutes;
            int rhsMinutes = (rhs.Hours * 60) + rhs.Minutes;

            if (Math.Abs(rhsMinutes - lhsMinutes) < 15)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}