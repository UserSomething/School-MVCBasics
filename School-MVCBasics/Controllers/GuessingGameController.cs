using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using School_MVCBasics.Models;
using System.Linq;
using System.Threading.Tasks;

namespace School_MVCBasics.Controllers
{
    public class GuessingGameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GuessingGame()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GuessingGame(int userGuess)
        {
            NumberGuessingGame guessingGame = new (userGuess);

            return View(guessingGame);
        }
    }
}
