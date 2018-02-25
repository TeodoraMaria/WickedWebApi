using System.IO;
using System.Web;
using System.Web.Mvc;
using WickedWebApi.BL.PopulateManager;
using WickedWebApi.BL.ScheduleManager;
using WickedWebApi.TL.Common;

namespace WickedWebApi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private static IScheduleManager _scheduleManager;

        private static IStudentsPopManager _studentsPopManager;
        public AdminController()
        {
            _scheduleManager = new ScheduleManager();
            _studentsPopManager = new StudentsPopManager();
        }

        public ViewResult UploadDocument()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadGroupTable(HttpPostedFileBase file)
        {
            string fileName = Path.GetFileName(file.FileName);
            string path = Path.Combine(Server.MapPath("~/App_Data/"), fileName);
            file.SaveAs(path);

            GroupTable groupTable = _studentsPopManager.ReadGroups(path);
            _studentsPopManager.AddGroups(groupTable);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult UploadTimeTable(HttpPostedFileBase file)
        {
            string fileName = Path.GetFileName(file.FileName);
            string path = Path.Combine(Server.MapPath("~/App_Data/"), fileName);
            file.SaveAs(path);

            GroupTable groupTable = _studentsPopManager.ReadGroups(path);
            _studentsPopManager.AddGroups(groupTable);
            return RedirectToAction("Index", "Home");
        }
    }
}