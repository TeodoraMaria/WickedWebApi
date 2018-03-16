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

        public ClassReport GetClassReportForActualClass(ActualClassDto actualClass)
        {
            ClassReport cr = new ClassReport();
            IList<FeedbackDto> feedbackDtos = _feedbackRepository.GetAllFeedbacksForActualClass(actualClass.Id);

            foreach (FeedbackDto dto in feedbackDtos)
            {
                cr.AttractivenessRating += dto.Attractiveness;
                cr.ClearnessRating += dto.Clearness;
                cr.ComprehensionRating += dto.Comprehension;
                cr.CorrectnessRating += dto.Correctness;
                cr.HighScientificLevelRating += dto.HighScientificLevel;
                cr.RigorousScientificLevelRating += dto.RigorousScientificLevel;
                cr.UsefulnessRating += dto.Usefulness;
                cr.NoveltyRating += dto.Novelty;
                cr.InteractivityRating += dto.Interactivity;
            }

            cr.InteractivityRating /= feedbackDtos.Count;
            cr.AttractivenessRating /= feedbackDtos.Count;
            cr.ClearnessRating /= feedbackDtos.Count;
            cr.ComprehensionRating /= feedbackDtos.Count;
            cr.CorrectnessRating /= feedbackDtos.Count;
            cr.HighScientificLevelRating /= feedbackDtos.Count;
            cr.NoveltyRating /= feedbackDtos.Count;
            cr.RigorousScientificLevelRating /= feedbackDtos.Count;
            cr.UsefulnessRating /= feedbackDtos.Count;

            cr.GeneralRating = (cr.InteractivityRating + cr.ClearnessRating + cr.CorrectnessRating +
                                cr.HighScientificLevelRating + cr.NoveltyRating + cr.RigorousScientificLevelRating +
                                cr.UsefulnessRating + cr.AttractivenessRating) / 8;
            return cr;
        }
    }
}