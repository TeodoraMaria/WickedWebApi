using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using SqlServerConnection;
using WickedWebApi.DAL;

namespace WickedWebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        [HttpPost]
        public string GetAll()
        {
            LoginContext loginContext = new LoginContext();
            
            return loginContext.Students.Select(st => st.ToString()).Aggregate((st1, st2) => st1 + st2);
        }

        [HttpPost]
        public string FindByName(string name)
        {
            LoginContext loginContext = new LoginContext();
            string result = loginContext.Students.Find(int.Parse(name))?.ToString();

            return result;
        }
    }
}