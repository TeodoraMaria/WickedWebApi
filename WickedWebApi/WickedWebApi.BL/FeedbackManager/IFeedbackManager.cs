using WickedWebApi.TL.Models;

namespace WickedWebApi.BL.FeedbackManager
{
    public interface IFeedbackManager
    {
        //string AddFeedback();
        int Add(FeedbackDto fb);
        ClassReport GetClassReportForActualClass(ActualClassDto actualClass);
    }
}