using System;
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
            var controller = ControllerContext.Controller;
            var controllerType = controller.GetType();
            if (controllerType != null && !string.IsNullOrEmpty(controllerType.Name))
            {
                ViewBag.AutoHtml = ControllerActionCollector.GetControllerNames(controllerType.Name);
            }
            
            return View();
        }

    }
}
