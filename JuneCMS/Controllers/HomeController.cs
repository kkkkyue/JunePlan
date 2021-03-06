﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JuneCMS.Controllers
{
    public class HomeController : Controller
    {
        JuneCMS.Data.CMSDbContext _context;
        public HomeController(JuneCMS.Data.CMSDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
