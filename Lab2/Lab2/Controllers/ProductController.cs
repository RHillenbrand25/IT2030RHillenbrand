﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductController : Controller
    {
        // GET: /Product/
        public string Index()
        {
            return "Product/Index is displayed.Index()";
        }
		// GET: /Product/Browse and /Product/Browse?genre=Disco
		public string Browse(string genre) //string genre
		{
			string message =
				HttpUtility.HtmlEncode("Product.Browse, Genre = " + genre);

			return message;
			// return "Browse displayed.Browse()";

		}
		// GET: /Product/Details/105
		public string Details(int id) //int id
		{
			string message = "Product.Details, ID = " + id;

			return message;

			// return "Details displayed for Id=105.Details()";

		}
		// GET: /Product/Location?zip=44124
		public string Location()
		{
			return "Location displayed for zip=44124.Location()";

		}
	}
}