﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHero.Controllers
{
    public class SuperHeroController : Controller
    {
        // GET: SuperHero
        public ActionResult Index()
        {
            return View();
        }
    }
}