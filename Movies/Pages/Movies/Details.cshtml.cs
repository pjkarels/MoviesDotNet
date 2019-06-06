using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Movies.Core;
using Movies.Data;

namespace Movies.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly IMovieData movieData;

        public Movie Movie { get; set; }

        public DetailsModel(IMovieData movieData)
        {
            this.movieData = movieData;
        }

        public IActionResult OnGet(int movieId)
        {
            Movie = movieData.GetMovieById(movieId);
            if (Movie == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
