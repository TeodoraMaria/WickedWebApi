

//using WickedWebApi.DAL;

using WickedWebApi.DAL.Account;

namespace WickedWebApi.BL.AccountManager
{
    public class AccountManager : IAccountManager
    {
        private readonly IAccountRepository _accountRepository;

        public AccountManager()
        {
            _accountRepository= new AccountRepository();
        }

       public bool CheckEmail(string email)
       {
           return _accountRepository.CheckEmail(email);
       }
    }
}
