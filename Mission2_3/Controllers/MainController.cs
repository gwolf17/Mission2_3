using Microsoft.AspNetCore.Mvc;
using Mission2_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission2_3.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Call when returning GradeCalculator page
        [HttpGet("GradeCalculator")]
        public IActionResult GradeCalculator()
        {
            return View();
        }

        //Call when clicking submit button
        [HttpPost("GradeCalculator")]
        public IActionResult GradeCalculator (CalculatorModel model)
        {
            return View();
        }
    }
}
