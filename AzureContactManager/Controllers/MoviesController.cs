﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AzureContactManager.Models;
namespace AzureContactManager.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie();

            movie.Name = "Shrek";
            
            return View(movie);
        }
    }
}