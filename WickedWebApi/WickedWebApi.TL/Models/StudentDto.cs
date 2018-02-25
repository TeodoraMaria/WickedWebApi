using System.Linq;
using WickedWebApi.BL.Models.Misc;

namespace WickedWebApi.BL.Models
{
    public class StudentDto
    {
        public StudentDto(AccountDto account)
        {
            Account = account;
            ForeignLanguage = new ForeignLanguage();
        }

       

        public int Id { get; set; }
        public string FirstName => Account.Email.Split(".".ToCharArray()).First();

        public string LastName => Account.Email.Split("@".ToCharArray()).First().Split(".".ToCharArray()).Last();
        

        public GroupDto Group { get; set; }
        public AccountDto Account { get; set; }
        public ForeignLanguage ForeignLanguage { get; set; }

    
        //Note? list<note> 
    }
}
