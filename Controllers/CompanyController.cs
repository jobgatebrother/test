﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JOBGATE_MVC_C.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Company()
        {
            return View();
        }

        public IActionResult Candidate()
        {
            return View();
        }

        public IActionResult MyCompany()
        {
            return View();
        }
    }
}
