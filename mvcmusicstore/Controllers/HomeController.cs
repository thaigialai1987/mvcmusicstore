﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcmusicstore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Here there.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact this.";

            return View();
        }
    }
}