namespace WickedWebApi.TL.Models
{
    public class FeedbackDto
    {
        public int Id { get; set; }
        public ActualClassDto ActualClass { get; set; }
        public int Usefulness { get; set; }
        public int Novelty { get; set; }
        public int HighScientificLevel { get; set; }
        public int RigorousScientificLevel { get; set; }
        public int Attractiveness { get; set; }
        public int Clearness { get; set; }
        public int Correctness { get; set; }
        public int Interactivity { get; set; }
        public int Comprehension { get; set; }
        public string Comment { get; set; }

        public FeedbackDto(ActualClassDto actualClass, int usefulness, int novelty, int highScientificLevel, 
            int rigorousScientificLevel, int attractiveness, int clearness, int correctness, int interactivity, int comprehension,
            string comment)
        {
            ActualClass = actualClass;
            Usefulness = usefulness;
            Novelty = novelty;
            HighScientificLevel = highScientificLevel;
            RigorousScientificLevel = rigorousScientificLevel;
            Attractiveness = attractiveness;
            Clearness = clearness;
            Correctness = correctness;
            Interactivity = interactivity;
            Comprehension = comprehension;
            Comment = comment;
        }

        public FeedbackDto()
        {

        }

    }
}
