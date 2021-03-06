﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreBackend.Models;

namespace AspNetCoreBackend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string tiedosto = @"/home/mika/CodeBootCamp/WebDemoCodeCamp/AspNetCoreBackend/wwwroot/Otsikot.txt";
            List<string> otsikot =
            System.IO.File.ReadAllLines(tiedosto).ToList();

            return View(otsikot);
        }
        
        public IActionResult Info()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
