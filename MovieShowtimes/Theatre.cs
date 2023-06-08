using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShowtimes
{
    public class Theatre
    {
        private List<Show> shows;
        int counter;

        public string Name { get; }

        public Theatre (string name)
        {
            Name = name;
            shows = new List<Show>();
        }
        
        public void AddShow (Show show)
        {
            shows.Add(show);
        }
        
        public void PrintShows()
        {
            Console.WriteLine($"\n{Name}");
            Console.WriteLine("All shows");
            Console.WriteLine("=============");

            counter = 1;

            foreach (Show index in shows)
            {
                Console.WriteLine($"{counter}: {index}");
                counter++;
            }
        }
       
        public void PrintShows(Day day)
        {
            Console.WriteLine($"\n{Name}");
            Console.WriteLine($"Movies on {day}");
            Console.WriteLine("=============");

            counter = 1;

            foreach (Show index in shows)
            {
                if (index.Day == day)
                {
                    Console.WriteLine($"{counter}: {index}");
                    counter++;
                }
            }

        }
        
        public void PrintShows(Genre genre)
        {
            Console.WriteLine($"\n{Name}");
            Console.WriteLine($"{genre} movies");
            Console.WriteLine("=============");

            counter = 1;

            foreach (Show index in shows)
            {
                if (index.Movie.Genre.HasFlag(genre))
                {
                    Console.WriteLine($"{counter}: {index}");
                    counter++;
                }
            }
        }

        public void PrintShows(string actor)
        {
            Console.WriteLine($"\n{Name}");
            Console.WriteLine($"{actor} movies");
            Console.WriteLine("=============");

            counter = 1;

            foreach (Show index in shows)
            {
                if (index.Movie.Cast.Contains(actor))
                {
                    Console.WriteLine($"{counter}: {index}");
                    counter++;
                }
            }
        }

        public void PrintShows(Time time)
        {
            Console.WriteLine($"\n{Name}");
            Console.WriteLine($"Movies @{time}");
            Console.WriteLine("=============");

            counter = 1;

            foreach (Show index in shows)
            {
                if (index.Time == time)
                {
                    Console.WriteLine($"{counter}: {index}");
                    counter++;
                }
            }
        }

        public void PrintShows(Day day, Time time)
        {
            Console.WriteLine($"\n{Name}");
            Console.WriteLine($"{day} movies @{time}");
            Console.WriteLine("=============");

            counter = 1;

            foreach (Show index in shows)
            {
                if (index.Day == day && index.Time == time)
                {
                    Console.WriteLine($"{counter}: {index}");
                    counter++;
                }
            }
        }
    }
}
