﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class OrganizeEventController : Controller
    {
        // GET: OrganizeEvent
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Edit()
		{
			return View();
		}

		public ActionResult Delete()
		{
			return View();
		}
	}
}