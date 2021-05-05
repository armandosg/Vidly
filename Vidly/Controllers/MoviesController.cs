﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private List<Movie> movies = new List<Movie>
        {
            new Movie { Id = 1, Name = "Shrek" },
            new Movie { Id = 2, Name = "Interstellar" }
        };

        public ActionResult Index()
        {
            var viewModel = new IndexMovieViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }

        // GET: Movies
        public ActionResult Random()
        {
            var Movie = new Movie()
            {
                Name = "Shrek!"
            };

            var Customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = Movie
            };

            return View(viewModel);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}