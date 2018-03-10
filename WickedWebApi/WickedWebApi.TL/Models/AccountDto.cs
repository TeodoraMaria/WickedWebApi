using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WickedWebApi.BL.Models
{
    public class AccountDto
    {
        public AccountDto()
        {
        }

        public AccountDto(int id)
        {
            Id = id;
        }

        public AccountDto(int id, string email, string password, int isAdmin):this(id)
        {
            Email = email;
            Password = password;
            IsAdmin = isAdmin;
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int IsAdmin { get; set; }
    }
}
