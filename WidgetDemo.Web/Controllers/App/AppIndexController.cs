using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WidgetDemo.Web.Controllers.App
{
    public class AppIndexController : AdminControllerBase
    {
        public ActionResult Index()
        {
            return View("~/Views/App/AppIndex/Index.html");
        }
    }
}