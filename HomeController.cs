﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Testing.Controllers
{
    public class HomeController : Controller
    {
        string TESTING = "THIS IS A TEST FOR A PULL REQUEST";
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page. THIS IS A TEST FOR THE COMMIT!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page. HELLO WORLD! THIS IS A NEW BRANCH TEST!";

            return View();
        }
    }
}