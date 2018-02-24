using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickedWebApi.BL.Models;

namespace WickedWebApi.BL.ScheduleManager
{
    public interface IScheduleManager
    {
        AppointmentDto GetCurrentAppointment(StudentDto studentDto);
        void ReadGroups(string path);
    }
}
