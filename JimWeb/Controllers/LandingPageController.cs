using System.Web.Mvc;

namespace JimWeb.Controllers
{
    public class LandingPageController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}