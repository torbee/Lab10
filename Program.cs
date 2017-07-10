using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();

            movies.Add(new Movie("Spirited Away", "animated"));
            movies.Add(new Movie("Moana", "animated"));
            movies.Add(new Movie("Good Will Hunting", "drama"));
            movies.Add(new Movie("Star Trek Beyond", "scifi"));
            movies.Add(new Movie("Star Wars: A New Hope", "scifi"));
            movies.Add(new Movie("Moonlight", "drama"));
            movies.Add(new Movie("The Conjuring", "horror"));
            movies.Add(new Movie("10 Cloverfield Lane", "horror"));
            movies.Add(new Movie("Alien", "scifi"));
            movies.Add(new Movie("Memoirs of a Geisha", "drama"));

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are " + movies.Count + " in this list.");
            Console.WriteLine("What category are you interested in?");
            string input = Console.ReadLine();

            MovieDB db = new MovieDB(movies); 
            db.PrintByCategory(input);
            }
        }
    }

