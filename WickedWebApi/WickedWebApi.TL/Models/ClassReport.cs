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

        public decimal GeneralTeacherRating { get; set; }
        public decimal GeneralComprehensionRating { get; set; }
        public decimal UsefulnessRating { get; set; }
        public decimal NoveltyRating { get; set; }
        public decimal HighScientificLevelRating { get; set; }
        public decimal RigorousScientificLevelRating { get; set; }
        public decimal AttractivenessRating { get; set; }
        public decimal ClearnessRating { get; set; }
        public decimal CorrectnessRating { get; set; }
        public decimal InteractivityRating { get; set; }

        public IList<string> Comments { get; set; }
    }
}
