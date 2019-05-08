using Movies.Core;
using System;
using System.Collections.Generic;

namespace Movies.Data
{
    public interface IMovieData
    {
        IEnumerable<Movie> GetAllMovies();
    }

    public class InMemoryMovieData : IMovieData
    {
        List<Movie> movies;

        public InMemoryMovieData()
        {
            movies = new List<Movie>()
            {
                new Movie {Id = 1, Title = "The Avengers", Description = "Earth's mightiest heros", Genre = Genre.Action, Location = "1A"},
                new Movie {Id = 2, Title = "Thor", Description = "God's son gets butt whipped", Genre = Genre.Action, Location = "1A"},
                new Movie {Id = 3, Title = "Iron Man", Description = "Playboy, Entreprenue, Philanthropist", Genre = Genre.Action, Location = "2A"},
                new Movie {Id = 4, Title = "Captian America", Description = "Dude never ages", Genre = Genre.Action, Location = "2A"},
                new Movie {Id = 5, Title = "Legally Blonde", Description = "Bel-Aire meets Harvard", Genre = Genre.Comedy, Location = "5B"}
            };
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return movies;
        }
    }
}
