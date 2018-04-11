using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace THE_FINAL_PROJECT.Controllers
{
    public class RechercheController : Controller
    {
        private FinalDBContext context = new FinalDBContext();
        // GET: Recherche
        public ActionResult Index()
        {
            return View();
        }

        public IEnumerable<Continent> GetAllContinents()
        {
            List<Continent> listeA = context.Continents.ToList();
            List<Continent> listeC = new List<Continent>();
            for (int i = 0; i < listeA.Count; i += 2)
            {
                listeC.Add(
                    new Continent
                    {
                        IdContinent = int.Parse(listeA[i].ToString()),
                        Nom = listeA[i + 1].ToString()
                    });
            }
            return listeC;
        }
    }
}