﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Testing.Controllers
{
    public class HomeController : Controller
    {
        string HELLO = "HELLO WORLD!";

        int testing = 1234;
        int finalTest = 9876;
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