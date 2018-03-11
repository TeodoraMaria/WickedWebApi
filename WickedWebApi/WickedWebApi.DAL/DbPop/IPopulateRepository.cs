using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickedWebApi.BL.Models;

namespace WickedWebApi.DAL.DbPop
{
    public interface IPopulateRepository
    {
        int AddGroup(GroupDto group);
        int AddAccount(AccountDto accountDto);
        void AddStudent(StudentDto studentDto);
        int AddSubject(SubjectDto subject);
        int AddClass(ClassDto classDto);
        int AddTeacher(TeacherDto teacher);
        int AddAppointment(AppointmentDto appointmentDto);
        int GetAccountIdByTeacherName(string name);
    }
}
