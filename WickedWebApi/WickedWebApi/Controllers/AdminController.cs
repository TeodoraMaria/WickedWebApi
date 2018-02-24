using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WickedWebApi.BL.ScheduleManager;

namespace WickedWebApi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private static IScheduleManager _scheduleManager;
        public AdminController()
        {
            _scheduleManager = new ScheduleManager();
        }

        public ViewResult UploadDocument()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadGroupTable(HttpPostedFileBase file)
        {
         
            var fileName = Path.GetFileName(file.FileName);
            var path = Path.Combine(Server.MapPath("~/App_Data/"), fileName);
            file.SaveAs(path);

            _scheduleManager.ReadGroups(path);
            return RedirectToAction("Index", "Home");
        }
    }
}