using System.Collections.Generic;
using DocumentFormat.OpenXml.Office2010.Excel;
using WickedWebApi.BL.Models;
using WickedWebApi.TL.Models;

namespace WickedWebApi.BL.StudentManager
{
    public interface IStudentManager
    {
        IList<AppointmentDto> GetAppointmentsForStudent(int idStudent);

    }
}