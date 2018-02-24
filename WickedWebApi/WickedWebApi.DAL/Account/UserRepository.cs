using System.Data;
using System.Data.SqlClient;
using WickedWebApi.BL.Models;

namespace WickedWebApi.DAL.Account
{
    public class UserRepository : IUserRepository
    {
        private const string CHECKEMAIL = "CheckEmail";


        public bool CheckEmail(string email)
        {
            using (SqlConnection connection = DatabaseProvider.GetSqlConnection())
            {
                SqlParameter parameter =new SqlParameter("@email", email);
                
                using (IDataReader reader =
                    DatabaseProvider.ExecuteCommand<IDataReader>(connection, CHECKEMAIL, CommandType.StoredProcedure, parameter))
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public int AddAccount(AccountDto accountDto)
        {

            return 1;
        }
    }
}