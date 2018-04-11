using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static THE_FINAL_PROJECT.Models.Repository;

namespace THE_FINAL_PROJECT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public void AfficheContinent()
        //{
        //    Continent continents = new Continent();
        //    RenderView("Index", continents);
        //}

        //public void AffichePays(long IdContinent)
        //{
        //    Pays pays = new Pays(IdContinent);
        //    RenderView("Index", pays);
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}