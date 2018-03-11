using System.Collections.Generic;
using WickedWebApi.TL.Models;

namespace WickedWebApi.DAL.Feedbacks
{
    public interface IFeedbackRepository
    {
        int AddFeedback(FeedbackDto feedback);
        IList<FeedbackDto> GetAllFeedbacksForActualClass(int classId);
    }
}
