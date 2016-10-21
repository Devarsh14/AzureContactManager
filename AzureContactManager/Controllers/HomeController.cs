using AzureContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AzureContactManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int min = 1;
            int max = 100;
            Random rnd = new Random();
            int rd= rnd.Next(min, max);
            string a = rd.ToString();
            ViewBag.No = a;


            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            var model = new AboutModel();
            model.Name = "Devarsh";
            model.Location = "Brisbane";
            //ViewBag.Location = "German";
            

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}