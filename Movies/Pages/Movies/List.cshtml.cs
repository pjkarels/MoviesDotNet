using Movies.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Movies.Core;

namespace Movies.Pages.Movies
{
    public class ListModel : PageModel
    {
        private readonly IMovieData movieData;

        public IEnumerable<Movie> Movies { get; set; }

        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }

        public ListModel(IMovieData movieData)
        {
            this.movieData = movieData;
        }

        public void OnGet()
        {
            Movies = movieData.GetMoviesByName(SearchTerm);
        }
    }
}
