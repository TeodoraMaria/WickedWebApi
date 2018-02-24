using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickedWebApi.BL.Models;

namespace WickedWebApi.TL.Common
{
    public class GroupTable
    {
        public GroupTable()
        {
            StudentDtos = new List<StudentDto>();
        }

        public GroupTable(string groupName) :this()
        {
            GroupDto = new GroupDto(-1,groupName);
        }

        public List<StudentDto> StudentDtos { get; set; }
        public GroupDto GroupDto { get; set; }

        public void AddStudent(StudentDto studentDto)
        {
            studentDto.Group = GroupDto;
            StudentDtos.Add(studentDto);
        }
    }
}
