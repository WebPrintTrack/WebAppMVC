﻿using System;
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
            // komentar za Novi_branch
            ViewBag.new_branch = "Kreiran je sljedeci branch; za novi view";
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
    }
}