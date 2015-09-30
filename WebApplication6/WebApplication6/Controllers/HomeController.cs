using System;
using System.Threading;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Numbers numbers = new Numbers();
            return View(numbers);
        }
        [HttpPost]
        public ActionResult RandomNumber(int value)
        {
            Random random = new Random();
            Numbers numbers = new Numbers();
            if (value != 0)
            {
                for (int i = 0; i < value; i++)
                {
                    numbers.randomNumbers.Numbers.Add(random.Next(1, 100));
                    Thread.Sleep(1000);
                   
                }
         
            }
            return Json(numbers, JsonRequestBehavior.AllowGet);
        }
        //[HttpPost]
        //public ActionResult Index(string color, string value)
        //{
        //    Numbers numbers = new Numbers();
        //    numbers.randomNumbers.Numbers.Add(int.Parse(value));
        //    return Json(numbers, JsonRequestBehavior.AllowGet);
        //}
    }
}