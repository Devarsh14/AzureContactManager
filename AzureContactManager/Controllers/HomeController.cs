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
        // private Vendor vendor= new Vendor();
        AzureContactManagerDev_dbEntities2 _entities = new AzureContactManagerDev_dbEntities2();
        public ActionResult Index()
        {
            Vendor vendor = new Vendor();


            


            return View(_entities.Vendors.ToList());
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