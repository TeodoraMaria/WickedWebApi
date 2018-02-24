using System.Data;
using System.Data.SqlClient;

namespace WickedWebApi.DAL.Account
{
    public class AccountRepository : IAccountRepository
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
    }
}