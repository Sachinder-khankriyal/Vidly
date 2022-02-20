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
        // GET: Movies
       public ActionResult Index()
        {
            var movie = new List<Movie>
            {
                 new Movie{Id=1,Name="Shrek!"},
                 new Movie {Id=3,Name="Boss" }

            };

            var viewModel = new RandomMovieViewModel
            {
                Movies = movie
                //Customers = customers
            };
            return View(viewModel);
        }
        

        public ActionResult Random()
        {
            var movie = new List<Movie>
            {
                 new Movie{Id=1,Name="Shrek!"},
                 new Movie {Id=3,Name="Boss" }

            };

        //return Content("Hello World");
        //return HttpNotFound();
        //return new EmptyResult();
        // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "Name" });

        //Pass Data to views
        // 1. Pass ViewData which is of type viewData disctionary
        //2.Pass viewBag which is an improvement to ViewData 
        //3. Best way is using Model of the viewResutlt
        //Don't use viewBag and Viewdata to passing data to views because it is fragile way to send data.
        //Best 

        //ViewData["Movie"] = movie;
        //ViewBag.Movie = movie;

        //you might be curious where does this movie object goes into viewResult.
        //this is actually happen but view method take care of this we don't have to write extra code
        //var viewResult = new ViewResult();
        //viewResult.ViewData.Model = movie;

        //var customers = new List<Customer>
        //{
        //    new Customer {Name="Customer 1" },
        //    new Customer {Name= "Customer 2"}
        //};

        var viewModel = new RandomMovieViewModel
            {
            Movies = movie
                //Customers = customers
            };


            //return View(movie);
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    // we have to define paramerter nullable to make it optional for this use  ? with integer
        //    // on the other hand in C# string is object type so it is nullable itself

        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }

        //    if (string.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "name";
        //    }
        //    return Content(string.Format("pageIndex ={0}&sortBy={1}", pageIndex, sortBy));
        //}

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content(year+"/"+month);
        }

        [Route("Movies/Details/{Id:regex(\\d{1})}")]
        public ActionResult Details(int Id)
        {
            return View();
        }
    }
}