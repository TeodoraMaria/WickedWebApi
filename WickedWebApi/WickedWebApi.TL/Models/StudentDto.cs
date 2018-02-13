using WickedWebApi.BL.Models.Misc;

namespace WickedWebApi.BL.Models
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GroupDto Group { get; set; }
        public AccountDto Account { get; set; }
        public ForeignLanguage ForeignLanguage { get; set; }

    
        //Note? list<note> 
    }
}
