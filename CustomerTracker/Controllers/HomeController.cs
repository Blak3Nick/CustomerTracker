﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult List()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}