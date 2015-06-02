﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Knockout.Controllers
{
    public class BaseController : Controller
    {
        //
        // GET: /Base/

        public ActionResult Index()
        {
            ViewBag.Href = ControllerActionCollector.GetControllerNames();
            return View();
        }

    }
}
