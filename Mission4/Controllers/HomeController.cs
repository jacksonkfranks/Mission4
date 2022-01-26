using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieCollectionContext blahContext { get; set; }

        //constructor, passing moviecollectioncontext someName
        public HomeController(ILogger<HomeController> logger, MovieCollectionContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        //return the index view
        public IActionResult Index()
        {
            return View();
        }

        //get and post methods for the movie submission form
        [HttpGet]
        public IActionResult MovieSubmission()
        {
            return View();
        }

        //make sure to add and save changes to the movies in the sqlite database
        [HttpPost]
        public IActionResult MovieSubmission(MovieResponse ar)
        {
            blahContext.Add(ar);
            blahContext.SaveChanges();

            return View("Confirmation", ar);
        }

        //podcast view page
        public IActionResult MyPodcasts()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
