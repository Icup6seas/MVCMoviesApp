using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMoviesApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index(string type)
        {
            string t = HttpUtility.HtmlEncode(type);
            if (t == "m")
            {
                ViewBag.Title = "Movie Index";
                return View("ManagerIndex");
            }
            else
                return View();
        }
        public ContentResult Search(string name)
        {
            var input = HttpUtility.HtmlEncode(name);
            return Content(input);
        }
        public string ListAllMovies()
        {
            return @"<ul>
                <li>Die Hard</li>
                <li>John Wick</li>
                <li>Alien</li>
                <li>Terminator</li>
                <li>Rambo</li>
                <li>Rocky</li>
                <li>Blood Sport</li>
                <li>Enter the Dragon</li>
                </ul>";
        }

        [HttpPost]
        public ActionResult NewMovie(string title, string director, int yearRelease, bool inCollection)
        {
            //I think ConfirmMovie.cshtml is preventing the formatting...
            ViewBag.Message =
            "Title: " + title + " " + Environment.NewLine +
            "Director: " + director + " " + Environment.NewLine +
            "Year Released: " + yearRelease + " " + Environment.NewLine +
            "In Collection?: " + inCollection;
            return View("ConfirmMovie");
        }

        public ActionResult NewMovie()
        {
            return View("NewMovieForm");
        }
    }
}