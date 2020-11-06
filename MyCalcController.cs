using simplecalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace simplecalculator.Controllers
{
    public class MyCalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new mycalc());
        }

        [HttpPost]
        public ActionResult Index(mycalc c, string calculate)
        {
            if (calculate == "add")
            {
                c.result = c.num1 + c.num2;
            }
            else if (calculate == "subt")
            {
                c.result = c.num1 - c.num2;
            }
            else if (calculate == "mul")
            {
                c.result = c.num1 * c.num2;
            }
            else
            {
                c.result = c.num1 / c.num2;
            }
            return View(c);
        }

    }
}