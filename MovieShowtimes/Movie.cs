using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShowtimes
{

    [Flags]
    public enum Genre
    {
        Unrated = 0,
        Action = 0b1,
        Adventure = 0b10,
        Animation = 0b100,
        Comedy = 0b1_000,
        Documentary = 0b10_000,
        Fantasy = 0b100_000,
        Horror = 0b1000_0000,
        Musical = 0b1_0000_0000,
        Mystery = 0b10_0000_0000,
        Romance = 0b100_0000_0000
    }
    public class Movie
    {
        public int Length { get; }
        public int Year { get; }
        public string Title { get; }
        public Genre Genre { get; private set; }
        public List<string> Cast { get; private set; }

        public Movie (string name, int year, int length)
        {
            Title = name;
            Year = year;
            Length = length;
            Cast = new List<string>();
        }

        public void AddActor(string actor)
        {
            Cast.Add(actor);
        }

        public void SetGenre (Genre genre)
        {
            Genre = genre;
        }

        public override string ToString()
        {
            return $"{Title} ({Year}) {Length}min ({Genre}) {string.Join(", ", Cast)}";
        }

    }
}
