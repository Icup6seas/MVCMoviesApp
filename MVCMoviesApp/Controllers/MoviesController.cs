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
        public ActionResult Index()
        {
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
    }
}