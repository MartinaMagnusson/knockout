using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Razor.Text;
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
        public JsonResult Index(int value)
        {
            var random = new Random();
            var randomNumbers = new RandomNumbers();
            if (value != 0)
            {
                for (int i = 0; i < value; i++)
                {
                    randomNumbers.Numbers.Add(random.Next(1, 100));
                    //randomNumbers.Numbers.Add(" ");
                    //Thread.Sleep(1000);
                }
            }
            var numbers = new Numbers(randomNumbers);
            var jsonResult = new JsonResult() {
                Data = numbers,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
            };

            return Json(jsonResult.Data);
            //Numbers numbers = new Numbers();
            //Random random = new Random();
            //if (value != 0)
            //{
            //    for (int i = 0; i < value; i++)
            //    {
            //        numbers.randomNumbers.Numbers.Add(random.Next(1,100));
            //        Thread.Sleep(1000);          
            //    }
            //}
            //return View(numbers);
            //return Json(numbers, JsonRequestBehavior.AllowGet);
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