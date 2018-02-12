using WickedWebApi.BL.Models.Misc;

namespace WickedWebApi.BL.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public Grupa Grupa { get; set; }
        public Cont Cont { get; set; }
        public LimbaStraina LimbaStraina { get; set; }

    
        //Note? list<note> 
    }
}
