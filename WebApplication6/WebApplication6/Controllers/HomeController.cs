using Numbers.HelperClasses;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            NumbersHelper numbersHelper = new NumbersHelper();
            
            return View(numbersHelper);
        }
    }
}