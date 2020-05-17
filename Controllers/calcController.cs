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
            try
            {
                int a = int.Parse(firstnum);
                int b = int.Parse(secondnum);
                double numberOne = (double)a;
                double numberTwo = (double)b;
                double result1 = Math.Sqrt(a);
                double result2 = Math.Sqrt(b);

                ViewBag.firstnum = firstnum;
                ViewBag.secondnum = secondnum;
                ViewBag.a = a;
                ViewBag.b = b;
                ViewBag.result1 = result1;
                ViewBag.result2 = result2;
                ViewBag.one = numberOne;
                ViewBag.two = numberTwo;
            }
            catch(FormatException e)
            {
                ViewBag.e = e.Message;
                Console.WriteLine($"{ViewBag.e}");
            }
            
            try
            {
                if (ViewBag.result1 == ViewBag.result2)
                {
                    Console.WriteLine("Both numbers have squareroots that are equal, Please enter another value");
                }
                else if (ViewBag.result1 != null && ViewBag.result2 != null && ViewBag.result1 > ViewBag.result2)
                {
                    //Calculates the greater value of the squareroot of the numbers entered by the user
                    Console.WriteLine($"The number {ViewBag.one} with a Squareroot of {ViewBag.result1} has a higher squareroot than {ViewBag.two} with a squareroot of {ViewBag.result2}.");
                }
                else if (ViewBag.result1 != null && ViewBag.result2 != null && ViewBag.result2 > ViewBag.result1)
                {
                    Console.WriteLine($"The number {ViewBag.two} with a Squareroot of {ViewBag.result2} has a higher squareroot than { ViewBag.one} with a squareroot of { ViewBag.result1}.");
                }
                else if(ViewBag.a < 0 || ViewBag.b < 0)
                {
                    Console.WriteLine("Please enter positive numbers only");
                }
                else if (ViewBag.a < 0 || ViewBag.b < 0)
                {
                    Console.WriteLine("Please enter positive numbers only.");
                }
            }
            catch (FormatException e)
            {
                ViewBag.error = e;
                Console.WriteLine($"{ViewBag.e}");
            }
            return View ();
           
        }
    }
}
