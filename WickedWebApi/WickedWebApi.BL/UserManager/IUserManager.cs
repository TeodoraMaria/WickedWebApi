
namespace WickedWebApi.BL.AccountManager
{
   public interface IUserManager
   {
      bool CheckEmail(string email);
      int LogIn(string email, string password);
      int Register(string email, string password, string foreignLanguage);
   }
}
