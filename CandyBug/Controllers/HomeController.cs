﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CandyBug.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //Set Route đến vùng Admin
            /*return View("~/Areas/Admin/Views/Home/Index.cshtml");*/
            return View();
        }

    }
}