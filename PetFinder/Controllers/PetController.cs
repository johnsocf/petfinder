﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetFinder.Controllers
{
    public class PetController : Controller
    {
        //
        // GET: /Pet/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Display()
        {
            var name = (string)RouteData.Values["id"];
          

            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }

    }
}
