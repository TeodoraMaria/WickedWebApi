using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickedWebApi.BL.Models;
using WickedWebApi.DAL.Feedbacks;
using WickedWebApi.DAL.Student;

namespace WickedWebApi.BL.StudentManager
{
    public class StudentManager : IStudentManager
    {
        private static IStudentRepository _studentRepository;

        public StudentManager()
        {
            _studentRepository = new StudentRepository();
        }
        public IList<AppointmentDto> GetAppointmentsForStudent(int idStudent)
        {
            return _studentRepository.GetAllAppointmentDtosForStudentDto(idStudent);
        }
    }
}
