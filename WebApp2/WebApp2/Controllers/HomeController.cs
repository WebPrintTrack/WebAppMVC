using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Amel_Novi_Branch()
        {
            
            return View();
        }


        public ActionResult Index()
        {
            //Ovo je drugi komentar
            return View();
        }

        public ActionResult About()
        {
            //Stvorio sam novi branch Printer 
            ViewBag.Message = "Your application description page novo dodano Igor.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}