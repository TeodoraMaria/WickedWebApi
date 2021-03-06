﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickedWebApi.BL.Models;
using WickedWebApi.DAL.DbPop;
using WickedWebApi.TL.Common;

namespace WickedWebApi.BL.ScheduleManager
{
    public class ScheduleManager : IScheduleManager
    {
        private static IPopulateRepository _populateRepository;

        public ScheduleManager()
        {
            _populateRepository = new PopulateRepository();
        }

        public AppointmentDto GetCurrentAppointment(StudentDto studentDto)
        {

            return null;
        }

        public TimeTable ReadScheduleTable(string path)
        {
            TimeTable timeTable = ExcelReader.ReadTimeTable(path);
            AddScheduleTable(timeTable);
            return timeTable;
        }

        public void AddScheduleTable(TimeTable timeTable)
        {
            timeTable.Groups.ForEach(group=> group.Id = _populateRepository.AddGroup(group));
            timeTable.Subjects.ForEach(subject => subject.Id = _populateRepository.AddSubject(subject));
            timeTable.Classes.ForEach(classDto => classDto.Id = _populateRepository.AddClass(classDto));
            //timeTable.Teachers.ForEach(teacher => teacher.Account.Id = _populateRepository.AddAccount(teacher.Account));
            timeTable.Teachers.ForEach(teacher =>
            {
                if ( (teacher.Id = _populateRepository.GetAccountIdByTeacherName(teacher.Name)) == 0)
                {
                    teacher.Account = new AccountDto(1);//id 1 means undefined Account
                    teacher.Id = _populateRepository.AddTeacher(teacher);

                }
            });
            timeTable.Appointments.ForEach(appointment=>appointment.Id = _populateRepository.AddAppointment(appointment) );
        }
    }
}
