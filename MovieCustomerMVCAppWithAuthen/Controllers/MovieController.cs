using MovieCustomerMVCAppWithAuthen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieCustomerMVCAppWithAuthen.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext dbContext;
        public MovieController()
        {
            dbContext = new ApplicationDbContext();
        }

        // GET: Movie
        public ActionResult Index()
        {
            var movies = dbContext.Movies.ToList();
            return View(movies);
        }
        public ActionResult Details(int id)
        {
            var singlemovie = dbContext.Movies.SingleOrDefault(m=>m.Id==id);
            if (singlemovie == null)
                return HttpNotFound();
            return View(singlemovie);
        }
    }
}