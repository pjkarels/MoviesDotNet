using Movies.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Movies.Data
{
    public interface IMovieData
    {
        IEnumerable<Movie> GetAllMovies();
        IEnumerable<Movie> GetMoviesByName(string name);
        Movie AddMovie(Movie movie);
        Movie GetMovieById(int id);
        Movie EditMovie(Movie movie);
        void DeleteMovie(int id);
    }

    public class InMemoryMovieData : IMovieData
    {
        List<Movie> movies;

        public InMemoryMovieData()
        {
            movies = new List<Movie>()
            {
                new Movie {Id = 1, Title = "The Avengers", Description = "Earth's mightiest heros", Genre = Genre.Action, Location = "1A"},
                new Movie {Id = 2, Title = "Thor", Description = "God's son learns a lesson", Genre = Genre.Action, Location = "1A"},
                new Movie {Id = 3, Title = "Iron Man", Description = "Playboy, Entreprenue, Philanthropist", Genre = Genre.Action, Location = "2A"},
                new Movie {Id = 4, Title = "Captian America", Description = "Dude never ages", Genre = Genre.Action, Location = "2A"},
                new Movie {Id = 5, Title = "Legally Blonde", Description = "Bel-Aire meets Harvard", Genre = Genre.Comedy, Location = "5B"}
            };
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return movies;
        }

        public IEnumerable<Movie> GetMoviesByName(string name = null)
        {
            return from r in movies
                   where string.IsNullOrEmpty(name) || r.Title.StartsWith(name)
                   orderby r.Title
                   select r;
        }

        public Movie GetMovieById(int id)
        {
            return movies.SingleOrDefault(m => m.Id == id);
        }

        public Movie AddMovie(Movie movie)
        {
            movie.Id = 999;
            movies.Add(movie);
            return movie;
        }

        public Movie EditMovie(Movie movie)
        {
            var movieToBeUpdated = movies.SingleOrDefault(m => m.Id == movie.Id);
            if (movieToBeUpdated != null)
            {
                movieToBeUpdated = movie;
            }

            return movie;
        }

        public void DeleteMovie(int id)
        {
            var movieToBeDeleted = movies.SingleOrDefault(m => m.Id == id);
            if (movieToBeDeleted != null)
            {
                movies.Remove(movieToBeDeleted);
            }
        }
    }
}