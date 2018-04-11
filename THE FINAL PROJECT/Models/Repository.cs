using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace THE_FINAL_PROJECT.Models
{
    //public class Repository
    //{
    //    public List<Continent> ListeContinent
    //    {
    //        get
    //        {
    //            return GetAllContinent();
    //        }
    //    }

    //    private static List<Continent> GetAllContinent()
    //    {
    //        List<Continent> listContinents = null;
    //        using (FinalDBContext context = new FinalDBContext())
    //        {
    //            listContinents = (from c in context.Continents
    //                          select c).ToList();
    //        }
    //        return listContinents;
    //    }

    //    public class Pays
    //    {
    //        private long IdContinent;
    //        public Pays(long idContinent)
    //        {
    //            IdContinent = idContinent;
    //        }
    //        public List<Pay> ListePays
    //        {
    //            get
    //            {
    //                return GetAllPays(IdContinent);
    //            }
    //        }

    //        private List<Pay> GetAllPays(long idContinent)
    //        {
    //            List<Pay> listePays = null;
    //            using (FinalDBContext context = new FinalDBContext())
    //            {
    //                listePays = (from p in context.Pays
    //                        where p.Continents. == idContinent
    //                        select p).ToList();


    //            }
    //            return listePays;
    //        }
    //    }

    //    public class Regions
    //    {
    //        private long IdPays;
    //        public Regions(long idPays)
    //        {
    //            IdPays = idPays;
    //        }
    //        public List<Pay> ListePays
    //        {
    //            get
    //            {
    //                return GetAllRegion(IdPays);
    //            }
    //        }

    //        private List<Pay> GetAllRegion(long idPays)
    //        {
    //            List<Pay> listeRegion = null;
    //            using (FinalDBContext context = new FinalDBContext())
    //            {
    //                listeRegion = (from r in context.Pays
    //                        where r.Continents. == idPays
    //                        select r).ToList();
    //            }
    //            return listeRegion;
    //        }
    //    }
    //}
}