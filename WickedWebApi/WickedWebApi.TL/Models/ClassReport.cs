using System;
using System.Collections.Generic;
using WickedWebApi.BL.Models;

namespace WickedWebApi.TL.Models
{
    public class ClassReport
    {
        public TeacherDto Teacher { get; set; }
        public SubjectDto Subject { get; set; }
        public ClassTypeEnum Type { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }

        public double GeneralRating { get; set; }
        public double ComprehensionRating { get; set; }
        public double UsefulnessRating { get; set; }
        public double NoveltyRating { get; set; }
        public double HighScientificLevelRating { get; set; }
        public double RigorousScientificLevelRating { get; set; }
        public double AttractivenessRating { get; set; }
        public double ClearnessRating { get; set; }
        public double CorrectnessRating { get; set; }
        public double InteractivityRating { get; set; }

        public IList<string> Comments { get; set; }

        public ClassReport()
        {
            GeneralRating = 0;
            ComprehensionRating = 0;
            UsefulnessRating = 0;
            NoveltyRating = 0;
            NoveltyRating = 0;
            HighScientificLevelRating = 0;
            RigorousScientificLevelRating = 0;
            AttractivenessRating = 0;
            ClearnessRating = 0;
            CorrectnessRating = 0;
            InteractivityRating = 0;
        }
    }
}
