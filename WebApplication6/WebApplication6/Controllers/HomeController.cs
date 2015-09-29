using DAL;
using System.Web.Mvc; 

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        private ContextRepositoryGet _get;
        public HomeController()
        {
            _get = new ContextRepositoryGet();
        }
        // GET: Home
        public ActionResult Index()
        { 
            var number = _get.GetAllNumbers();
            return View(number);
        }
    }
}