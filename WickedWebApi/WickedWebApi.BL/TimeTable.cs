using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickedWebApi.BL.Models;

namespace WickedWebApi.BL
{
    public class TimeTable
    {
        public TimeTable()
        {
            Groups = new List<GroupDto>();
            Appointments = new List<AppointmentDto>();
            Classes = new List<ClassDto>();
            Subjects = new List<SubjectDto>();
            Teachers = new List<TeacherDto>();
        }

        public List<GroupDto> Groups { get; set; }
        public List<AppointmentDto> Appointments { get; set; }
        public List<SubjectDto> Subjects { get; set; }
        public List<TeacherDto> Teachers { get; set; }
        public List<ClassDto> Classes { get; set; }
        //public List<>
    }
}
