using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickedWebApi.BL.Models;
using WickedWebApi.TL.Common;

namespace WickedWebApi.BL.ScheduleManager
{
    public interface IScheduleManager
    {
        AppointmentDto GetCurrentAppointment(StudentDto studentDto);

        TimeTable ReadScheduleTable(string path);
    }
}
