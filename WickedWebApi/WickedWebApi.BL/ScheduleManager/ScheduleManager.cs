using System;
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

        public void ReadGroups(string path)
        {
            GroupTable groupTable = ExcelReader.ReadGroupDto(path);
            int groupId = _populateRepository.AddGroup(groupTable.GroupDto);
            groupTable.StudentDtos.ForEach(student=>);
        }
    }
}
