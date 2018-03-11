using System.Collections.Generic;
using WickedWebApi.DAL.Feedbacks;
using WickedWebApi.TL.Models;

namespace WickedWebApi.BL.FeedbackManager
{
    public class FeedbackManager : IFeedbackManager
    {
        private static IFeedbackRepository _feedbackRepository;

        public FeedbackManager()
        {
            _feedbackRepository = new FeedbackRepository();
        }

        //public string AddFeedback()
        //{
        //    SubjectDto subjectDto = new SubjectDto(1467,"Subject");
        //    ClassDto classDto = new ClassDto(){ Id = 1839, Subject = subjectDto, ClassType=ClassTypeEnum.C};
        //    ActualClassDto actualClassDto = new ActualClassDto() { Id = 1 ,Date = DateTime.Today, Class = classDto };
        //    FeedbackDto fb = new FeedbackDto() { Attractiveness = 3, Clearness = 3, Comprehension = 5,  Correctness = 3, HighScientificLevel = 3, Interactivity = 3, Novelty = 3, RigorousScientificLevel = 3, Usefulness = 3, ActualClass = actualClassDto};

        //    JavaScriptSerializer sr = new JavaScriptSerializer();
        //    string message= sr.Serialize(fb);

        //    return message;
        //}

        public int Add(FeedbackDto fb)
        {
            return _feedbackRepository.AddFeedback(fb);
        }

        public void GetClassReportForActualClass(ActualClassDto actualClass)
        {
            IList<FeedbackDto> feedbackDtos = _feedbackRepository.GetAllFeedbacksForActualClass(actualClass.Id);
        }
    }
}