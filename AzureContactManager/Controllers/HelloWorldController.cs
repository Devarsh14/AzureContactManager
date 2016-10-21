using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureContactManager.Controllers
{
    public class HelloWorldController : Controller
    {
        public ActionResult Dev()
        {
            ViewBag.Message="ur first devpage"
            return View();
        }

        }
    }
}