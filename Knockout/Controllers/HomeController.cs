﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Knockout.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            ViewBag.AutoHtml = ControllerActionCollector.GetControllerNames();
            return View();
        }
    }
}
