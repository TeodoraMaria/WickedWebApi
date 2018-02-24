using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickedWebApi.BL.Models;

namespace WickedWebApi.DAL.DbPop
{
    public class PopulateRepository:IPopulateRepository
    {
        private const string ADDGROUP = "AddGroup";

        public int AddGroup(GroupDto @group)
        {
            using (SqlConnection connection = DatabaseProvider.GetSqlConnection())
            {
                SqlParameter[] parameter = new SqlParameter[]
                {
                    new SqlParameter("@name", group.Name),
                };

                using (IDataReader reader =
                    DatabaseProvider.ExecuteCommand<IDataReader>(connection, ADDGROUP, CommandType.StoredProcedure, parameter))
                {
                    if (reader.Read())
                    {

                        return int.Parse(reader["Id"].ToString());
                    }
                    return 0;
                }
            }
        }

        public int AddStudent(StudentDto studentDto)
        {
            using (SqlConnection connection = DatabaseProvider.GetSqlConnection())
            {
                SqlParameter[] parameter = new SqlParameter[]
                {
                    new SqlParameter("@name", studentDto.FirstName),
                };

                using (IDataReader reader =
                    DatabaseProvider.ExecuteCommand<IDataReader>(connection, ADDGROUP, CommandType.StoredProcedure, parameter))
                {
                    if (reader.Read())
                    {

                        return int.Parse(reader["Id"].ToString());
                    }
                    return 0;
                }
            }
        }
    }
}
