using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using WickedWebApi.BL.FeedbackManager;
using WickedWebApi.TL.Models;

namespace WickedWebApi.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Title = "Home Page";
            IFeedbackManager fb = new FeedbackManager();
            fb.GetClassReportForActualClass(new ActualClassDto(){Id = 1});
            return View();
        }
       
    }
}