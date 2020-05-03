﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LB.Models;

namespace LB.Controllers
{
    public class HomeController : Controller
    {
        private ProductData data;
        public HomeController(ProductData productData)
        {
            data = productData;
        }
        public IActionResult Index()
        {
            return View(data.ProductList);
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}

