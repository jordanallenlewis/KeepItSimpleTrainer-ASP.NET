﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KeepItSimpleTrainer.Controllers
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

        public ActionResult CreateModule()
        {
            ViewBag.Message = "Create Modules Page";

            return View();
        }
        public ActionResult SearchModules()
        {
            ViewBag.Message = "Search";

            return View();
        }
    }
}