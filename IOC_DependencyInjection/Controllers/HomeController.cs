using IOC_DependencyInjection.Repositories;
using System.Web.Mvc;

namespace IOC_DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private IData _repositories;

        public HomeController(IData repository)
        {
            _repositories = repository;
        }


        public ActionResult Index()
        {
            ViewBag.Data = _repositories.Names();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}