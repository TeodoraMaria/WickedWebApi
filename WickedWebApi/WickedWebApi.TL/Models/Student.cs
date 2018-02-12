using WickedWebApi.BL.Models.Misc;

namespace WickedWebApi.BL.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Group Group { get; set; }
        public Account Account { get; set; }
        public ForeignLanguage ForeignLanguage { get; set; }

    
        //Note? list<note> 
    }
}
