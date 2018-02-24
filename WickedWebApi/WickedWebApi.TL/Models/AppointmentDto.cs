using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickedWebApi.BL.Models.Misc;

namespace WickedWebApi.BL.Models
{
    public class AppointmentDto
    {
        public AppointmentDto()
        {
        }

        public AppointmentDto(int id, ClassDto curs, TeacherDto teacher, string day,string hours ,string corp, string sala, GroupDto grupa)
        {
            Id = id;
            Class = curs;
            Day = day;
            Hours = hours;
            Corp = corp;
            ClassRoom = sala;
            Group = grupa;
        }

        public int Id { get; set; }
        public ClassDto Class { get; set; }
        public string Day { get; set; }
        public string Hours { get; set; }
        public string Corp { get; set; }
        public string ClassRoom { get; set; }
        public GroupDto Group { get; set; }
        public TeacherDto Teacher { get; set; }
    }

  
}
