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
            ViewBag.Message = "Create Modules Page - Andy Gandara";

            return View();
        }

        public ActionResult AddUser()
        {
            ViewBag.Message = "Add New User - Andy Gandara";

            return View();
        }

        public ActionResult ViewUsers()
        {
            ViewBag.Message = "View Users - Andy Gandara";

            return View();
        }
    }
}