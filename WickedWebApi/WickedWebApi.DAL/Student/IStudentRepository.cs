using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickedWebApi.BL.Models;

namespace WickedWebApi.DAL.Student
{
    public interface IStudentRepository
    {
        IList<AppointmentDto> GetAllAppointmentDtosForStudentDto(int studentId);
    }
}
