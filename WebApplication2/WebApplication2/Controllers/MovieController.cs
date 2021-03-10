using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [RoutePrefix("movie")]
    public class MovieController : Controller
    {
        // GET: Movie
        [Route]
        public ActionResult List()
        {
            var movies = GetMoviesList();
            return View(movies);
        }

        [Route("editing/{id}")]
        public ViewResult Edit(string id)
        {
            MovieData movie = GetMoviesList().Find(x => x.Id.Equals(id));
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(string id,FormCollection formCollection)
        {
            var movie = GetMoviesList().Where(x => x.Id.Equals(id));
            try { if (TryUpdateModel(movie))
                    return RedirectToAction("List");
                        }
            catch { return View(); }
            return View(movie);
        }

        [NonAction]
        public List<MovieData> GetMoviesList()
        {
            return new List<MovieData> {
                new MovieData
                {
                    Id="1",
                    Name = "BlackPanther",
                    category = MovieData.Category.Drama,
                    releaseYear = "2018",
                    imageUrl = "@.\\Content\\Images\\BlackPanther_Drama.jpg"
                },
                new MovieData
                {
                    Id="2",
                    Name = "ColdFusion",
                    category = MovieData.Category.Action,
                    releaseYear = "2019",
                    imageUrl = "@.\\Content\\Images\\Coldfusion_action.jpg"
                },
                new MovieData
                {
                    Id="3",
                    Name = "Lockout",
                    category = MovieData.Category.Triller,
                    releaseYear = "2020",
                    imageUrl = "@.\\Content\\Images\\Lockout_thriller.jpg"
                },
                new MovieData
                {
                    Id="3",
                    Name = "Terminator",
                    category = MovieData.Category.Romance,
                    releaseYear = "2021",
                    imageUrl = "@.\\Content\\Images\\Terminator_Romance.jpg"
                }
            };
        }
    }
}