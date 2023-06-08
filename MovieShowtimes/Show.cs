using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieShowtimes
{

    public enum Day {Sun, Mon, Tue, Wed, Thu, Fri, Sat}
    public struct Show
    {
        public double Price { get; }
        public Day Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }

        public Show(Movie movie, Day day, double price, Time time)
        {
            Movie = movie;
            Day = day;
            Price = price;
            Time = time;
        }
        public override string ToString()
        {
            return $"{Day} {Time} {Movie} {Price:C2}";
        }
    }
}