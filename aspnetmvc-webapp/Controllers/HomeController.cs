using AspNetMvc5.DemoLib;
using System.Web.Mvc;

namespace aspnetmvc_webapp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ServerTimeNow = Utils.GetDateTimeNow();

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