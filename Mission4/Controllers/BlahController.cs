﻿using Microsoft.AspNetCore.Mvc;
using Mission4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Controllers
{
    public class BlahController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult calculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult calculator(calculatorModel model)
        {
            return View();
        }


    }
}
