using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickedWebApi.DAL.DbPop;
using WickedWebApi.TL.Common;

namespace WickedWebApi.BL.PopulateManager
{
    public class StudentsPopManager : IStudentsPopManager
    {
        private static IPopulateRepository _populateRepository;

        public StudentsPopManager()
        {
            _populateRepository = new PopulateRepository();

        }

        public GroupTable ReadGroups(string path)
        {

            GroupTable groupTable = ExcelReader.ReadGroupDto(path);
            return groupTable;
            
            //roupTable.StudentDtos.ForEach(student=>);
        }

        public void AddGroups(GroupTable groupTable){
            groupTable.GroupDto.Id = _populateRepository.AddGroup(groupTable.GroupDto);

            groupTable.StudentDtos.ForEach(student =>
            {
                student.Account.Id = _populateRepository.AddAccount(student.Account);
                _populateRepository.AddStudent(student);
            });
        }
    }
}
