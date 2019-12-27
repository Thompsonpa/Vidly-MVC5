using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/View
        public ActionResult view()
        {
            var movies = new List<Movies>
            {
                new Movies { Name = "Shrek!", Id = 1},
                new Movies { Name = "Finding Nemo", Id = 2},
                new Movies { Name = "The Blind Side", Id = 3},
                new Movies { Name = "Cars", Id = 4},
                new Movies { Name = "2 Fast 2 Furious", Id = 5},
            };

            var viewModel = new MovieListViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }

        //GET: Edit Movies/Edit/{id}
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("Movies/Released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }
        
    }
}