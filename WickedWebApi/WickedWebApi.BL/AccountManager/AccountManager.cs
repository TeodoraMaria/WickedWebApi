

//using WickedWebApi.DAL;

namespace WickedWebApi.BL.AccountManager
{
    public class AccountManager : IAccountManager
    {
       public bool CheckEmail(string email)
       {
           if (email.Contains("student"))
               return true;
           else return false;
       }
    }
}
