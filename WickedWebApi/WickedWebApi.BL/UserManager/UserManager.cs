

//using WickedWebApi.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using WickedWebApi.BL.Models;
using WickedWebApi.DAL.Account;
using WickedWebApi.TL.Common;

namespace WickedWebApi.BL.AccountManager
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _accountRepository;

        public UserManager()
        {
            _accountRepository= new UserRepository();
        }

       public bool CheckEmail(string email)
       {
           return _accountRepository.CheckEmail(email);
       }

        public int LogIn(string email, string password)
        {
            password = PasswordHashing.Hash(password);
            return _accountRepository.LogIn(email, password);
        }

        public int Register(string email, string password, string foreignLanguage)
        {
            int foreignLanguageId = GetForeignLanguageByName(foreignLanguage);
            password = PasswordHashing.Hash(password);
            return _accountRepository.Register(email, password, foreignLanguageId);
        }

        public AppointmentDto GetNextAppointmentDtoForStudentDto(List<AppointmentDto> appointmentDtos,
            StudentDto studentDto)
        {
            int day = (DateTime.Now - new DateTime(2018, 2, 18)).Days %14;
            int hour = DateTime.Now.Hour;

            return appointmentDtos.Where(appointment =>
                int.Parse(appointment.Day) > day && int.Parse(appointment.Hours) > hour).Aggregate((a, b) =>
            {
                int aDay = int.Parse(a.Day);
                int bDay = int.Parse(b.Day);

                if (aDay > bDay)
                {
                    return a;
                }
                else if (aDay < bDay)
                {
                    return b;
                }
                else
                {
                    int aHour = int.Parse( a.Hours);
                    int bHour = int.Parse(b.Hours);

                    if (aHour > bHour) return a;
                    else return b;
                }
            });
        }

        public List<AppointmentDto> GetAppointmentDtosForStudentDto(TimeTable timeTable,StudentDto studentDto)
        {
            return timeTable.Appointments.Where(appointement => appointement.Group.Equals(studentDto.Group)).ToList();
        }

        public int GetForeignLanguageByName(string foreignLanguage)
        {
            return _accountRepository.GetForeignLanguageByName(foreignLanguage);
        }

       /* public void PopulateDbFromGroupTable(GroupTable groupTable)
        {
            groupTable.StudentDtos.ForEach(student=>
            {
                int id =_accountRepository.AddAccount(student.Account);

            });
        }*/

        
    }
}
