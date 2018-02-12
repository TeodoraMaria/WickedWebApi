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
            Groups = new List<Group>();
            Appointments = new List<Appointment>();
        }

        public List<Group> Groups { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Teacher> Teachers { get; set; }
        //public List<>
    }
}
