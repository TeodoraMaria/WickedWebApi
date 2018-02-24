﻿

//using WickedWebApi.DAL;

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

        public void PopulateDbFromGroupTable(GroupTable groupTable)
        {
            groupTable.StudentDtos.ForEach(student=>
            {
                int id =_accountRepository.AddAccount(student.Account);

            });
        }
    }
}