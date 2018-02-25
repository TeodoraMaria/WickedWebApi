using System.Data;
using System.Data.SqlClient;
using WickedWebApi.BL.Models;

namespace WickedWebApi.DAL.Account
{
    public class UserRepository : IUserRepository
    {
        private const string CHECKEMAIL = "CheckEmail";
        private const string LOGIN = "LogIn";
        private const string REGISTER = "Register";


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

        public int LogIn(string email,string password)
        {
            using (SqlConnection connection = DatabaseProvider.GetSqlConnection())
            {
                SqlParameter[] parameter = {new SqlParameter("@email", email), new SqlParameter("@password", password) };

                using (IDataReader reader =
                    DatabaseProvider.ExecuteCommand<IDataReader>(connection, LOGIN, CommandType.StoredProcedure, parameter))
                {
                    if (reader.Read())
                    {
                        return (int)reader["id"];
                    }
                }
            }
            return -1;
        }

        public int Register(string email, string password,string foreignLanguage)
        {
            using (SqlConnection connection = DatabaseProvider.GetSqlConnection())
            {
                SqlParameter[] parameter = { new SqlParameter("@email", email), new SqlParameter("@password", password), new SqlParameter("@foreignLanguage", foreignLanguage) };

                using (IDataReader reader =
                    DatabaseProvider.ExecuteCommand<IDataReader>(connection, REGISTER, CommandType.StoredProcedure, parameter))
                {
                    if (reader.Read())
                    {
                        return (int)reader["id"];
                    }
                }
            }
            return -1;
        }

        public int AddAccount(AccountDto accountDto)
        {

            return 1;
        }
    }
}