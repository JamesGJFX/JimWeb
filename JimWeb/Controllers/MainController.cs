using System.Web.Mvc;

namespace JimWeb.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Goal()
        {
            return View();
        }
    }
}