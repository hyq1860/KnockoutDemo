using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Knockout.Controllers
{
    public class BootstrapController : BaseController
    {
        public ActionResult Weather()
        {
            return View();
        }
    }
}
