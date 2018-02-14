using System.Data;
using System.Data.SqlClient;


namespace WickedWebApi.DAL
{
    public class DatabaseRepository
    {
        #region Properties

        public SqlConnection Connection { get; set; }

        #endregion

        #region Methods - Protected

        /// <summary>
        ///     Create sql command.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="commandType"></param>
        /// <returns>A new sql command.</returns>
        protected SqlCommand GetCommand(string name, CommandType commandType = CommandType.StoredProcedure)
        {
            SqlCommand command = new SqlCommand(name, Connection) { CommandType = commandType };

            return command;
        }

        /// <summary>
        ///     Create and open an sql connection.
        /// </summary>
        /// <returns>A new open sql connection</returns>
        protected SqlConnection GetConnection()
        {
            Connection = DatabaseProvider.GetSqlConnection();

            if (Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }

            return Connection;
        }

        #endregion
    }
}


