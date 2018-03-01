using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WickedWebApi.BL.Models
{
    public class TeacherDto
    {
        public TeacherDto(int id,string name)
        {
            Id = id;
            Name = name;
            Account = new AccountDto();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public AccountDto Account { get; set; }
        public IList<ClassDto> Classes { get; set; }
    }
}
