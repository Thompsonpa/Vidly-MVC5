using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieViewModel
    {
        public class List
        {
            public List<Movie> MovieList { get; set; }
        }  

        public class Movie
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Genre Genre { get; set; }
            public string ReleaseDate { get; set; }
            public string DateAdded { get; set; }
            public int NumberInStock { get; set; }
        }
    }
}