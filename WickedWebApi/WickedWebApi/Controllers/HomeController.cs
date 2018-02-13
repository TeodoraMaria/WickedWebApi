using System.Configuration;
using System.Linq;
using System.Web.Mvc;

namespace WickedWebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
       
    }
}