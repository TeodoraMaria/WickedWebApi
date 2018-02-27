

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
