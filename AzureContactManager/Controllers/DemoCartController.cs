using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AzureContactManager.Models;

namespace AzureContactManager.Controllers
{
    public class DemoCartController : Controller
    {
        // GET: DemoCart
        AzureContactManagerDev_dbEntities2 db = new AzureContactManagerDev_dbEntities2();
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ShowProduct()
        {
            
            return View(db.Products.ToList());
            
        }
       
    }
}