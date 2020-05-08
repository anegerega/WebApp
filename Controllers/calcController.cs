using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_App.Controllers
{
    public class calcController : Controller
    {
         [HttpGet]
        public ActionResult calc()
        {
            return View();
        }
        [HttpPost]
        public ActionResult calc(string firstnum, string secondnum)
        {
            double numberOne = double.Parse (firstnum);
            double numberTwo = double.Parse (secondnum);
            double result1 = Math.Sqrt (double.Parse (firstnum));
            double result2 = Math.Sqrt (double.Parse (secondnum));

            ViewBag.result1 = result1;
            ViewBag.result2 = result2;
            ViewBag.one = numberOne;
            ViewBag.two = numberTwo;
            if (ViewBag.result1 != null && ViewBag.result2 != null)
            {
                try
                {
                    if (ViewBag.result1 > ViewBag.result2)
                    {
                        Console.WriteLine($"The number {ViewBag.one} with Square root {ViewBag.result1} has a higher square root than {ViewBag.two} with square root {ViewBag.result2}");
                    } else if (ViewBag.second > ViewBag.first) {
                        Console.WriteLine ($"The number {ViewBag.two} with Square root {ViewBag.result2} has a higher square root than {ViewBag.one} with square root {ViewBag.result1}");
                    } else if (ViewBag.result1 == ViewBag.result2 && ViewBag.result2 == ViewBag.one) {
                        Console.WriteLine ($"The number { ViewBag.one } with Square root { ViewBag.result1 } has the same Value with { ViewBag.two } with square root {ViewBag.result2} PLEASE ENTER DIFFERENT VALUES");
                    }
                } catch (FormatException) {
                    Console.WriteLine ($"WRONG INPUT PLEASE ENTER A POSITIVE VALUE!!");
                }
            }
            return View ();
        }
    }
}
