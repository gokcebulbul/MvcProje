﻿using BusinessLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager categoryManager = new CategoryManager();
        public ActionResult Index()
        {
            var categoryValues = categoryManager.GetAll();
            return View();
        }
    }
}