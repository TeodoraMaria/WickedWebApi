using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using WickedWebApi.BL.FeedbackManager;
using WickedWebApi.BL.StudentManager;
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

        [HttpGet]
        public string GetAppointments(int id)
        {
            IStudentManager studentManager = new StudentManager();
            studentManager.GetAppointmentsForStudent(0);
            return studentManager.GetAppointmentsForStudent(0).Count.ToString();
        }
       
    }
}