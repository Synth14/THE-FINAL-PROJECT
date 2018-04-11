using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace THE_FINAL_PROJECT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
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
        [Authorize(Roles = "AdminCommercial, superadmin")]
        public ActionResult GestionMailing()
        {
            ViewBag.Message = "Mailing side";
            return View();
        }
        [Authorize(Roles = "AdminCommercial, superadmin")]
        public ActionResult GestionCommande()
        {
            ViewBag.Message = "Commande side";
            return View();
        }
        [Authorize]
        public ActionResult Attribuer()
        {
            if (!Roles.RoleExists("AdminCommercial")) Roles.CreateRole("AdminCommercial");
            if (!Roles.RoleExists("superadmin")) Roles.CreateRole("superadmin");
            if (!Roles.RoleExists("AdminMailing")) Roles.CreateRole("AdminMailing");
            if (!Roles.IsUserInRole("manchon.maxime@gmail.com", "superadmin"))
                Roles.AddUserToRole("manchon.maxime@gmail.com", "superadmin");
            ViewBag.Message = "Passage en mode SuperUser";
            return View();
        }
    }
}