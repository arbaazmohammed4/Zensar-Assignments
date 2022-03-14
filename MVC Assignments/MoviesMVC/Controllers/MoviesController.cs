using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAssignment2.Models;

namespace MVCAssignment2.Controllers
{
    public class MoviesController : Controller
    {
        MoviesDBEntities mvdb = new MoviesDBEntities();
        // GET: Movies
        public ActionResult Index()
        {
            return RedirectToAction("GetMoviesScaffolded");
        }

        public ActionResult GetMoviesScaffolded()
        {
            List<MoviesTable> moviesdb = mvdb.MoviesTables.ToList();
            return View(moviesdb);
        }
        // Crud Operations to create and post of create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(MoviesTable cat)
        {
            mvdb.MoviesTables.Add(cat);
            mvdb.SaveChanges();
            return RedirectToAction("GetMoviesScaffolded");
        }

        // get details of a particular Movies ID
        public ActionResult Details(int id)
        {
            MoviesTable c = mvdb.MoviesTables.Find(id);
            return View(c);
        }

        // Edit records
        [HttpGet]
        public ActionResult Edit(int id)
        {
            MoviesTable cat = mvdb.MoviesTables.Find(id);
            return View(cat);
        }

        [HttpPost]
        public ActionResult Edit(MoviesTable movie)
        {
            MoviesTable mvs = mvdb.MoviesTables.Find(movie.Movie_ID); //getting the before update data
            mvs.Movie_Name = movie.Movie_Name; //setting the updated data to the cat object
            mvs.Movie_DOR = movie.Movie_DOR;
            mvdb.SaveChanges();
            return RedirectToAction("GetMoviesScaffolded");
        }

        //Delete a record

        public ActionResult Delete(int id)
        {
            MoviesTable cat = mvdb.MoviesTables.Find(id);
            mvdb.MoviesTables.Remove(cat);
            mvdb.SaveChanges();
            return RedirectToAction("GetMoviesScaffolded");

        }

        public ActionResult GetMoviesByYear(string search)
        {
            List<MoviesTable> movies = (from m in mvdb.MoviesTables
                                        where m.Movie_DOR.ToString().Contains(search) || search == null
                                        select m).ToList();
            return View(movies);
        }

    }
}