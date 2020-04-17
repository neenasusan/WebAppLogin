using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLogin.Models;


namespace WebAppLogin.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
      var movie = new Movie() { Name = "The call" };
            return View(movie);
        }
        public ActionResult Edit(int id )
        {
          return Content("hello" + id);
        }
        [Route("movies/released/{year}/{month:regex(\\d{2})}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
        return Content(year+"/"+month);

        }
        
    }
}
