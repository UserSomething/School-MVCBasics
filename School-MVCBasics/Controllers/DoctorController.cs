using School_MVCBasics.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_MVCBasics.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FeverCheck(double celcius)
        {
            FeverCheckerProgram feverChecker = new (celcius);

            return View(feverChecker);
        }
    }
}
