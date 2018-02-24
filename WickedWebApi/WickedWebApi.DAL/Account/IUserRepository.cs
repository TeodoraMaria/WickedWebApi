
using WickedWebApi.BL.Models;

namespace WickedWebApi.DAL.Account
{
    public interface IUserRepository
    {
        bool CheckEmail(string email);

        int AddAccount(AccountDto accountDto);

    }
}
