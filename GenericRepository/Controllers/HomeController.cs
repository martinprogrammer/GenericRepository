using GenericRepository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenericRepository.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Movie> _repository;
       

        public HomeController() : this(new MovieRepository())
        {
           
        }

        public HomeController(IRepository<Movie> repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            var result = _repository.GetAll();

            return View(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
