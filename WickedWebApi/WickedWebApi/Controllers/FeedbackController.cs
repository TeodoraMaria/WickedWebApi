using System.Web.Mvc;
using System.Web.Script.Serialization;
using WickedWebApi.BL.FeedbackManager;
using WickedWebApi.TL.Models;

namespace WickedWebApi.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackManager _feedbackManager;

        public FeedbackController()
        {
            _feedbackManager = new FeedbackManager();
        }

        [HttpPost]
        public void SubmitFeedback(string feedback)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            FeedbackDto fb = sr.Deserialize<FeedbackDto>(feedback);
            int id = _feedbackManager.Add(fb);
        }
    }
}