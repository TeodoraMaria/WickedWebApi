﻿using System;
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
        private const string ADDACCOUNT = "AddAccount";
        private const string ADDSTUDENT = "AddStudent";


        public int AddGroup(GroupDto @group)
        {
            using (SqlConnection connection = DatabaseProvider.GetSqlConnection())
            {
                SqlParameter parameter = new SqlParameter("@name", group.Name);
                

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

        public int AddAccount(AccountDto accountDto)
        {
            using (SqlConnection connection = DatabaseProvider.GetSqlConnection())
            {
                SqlParameter[] parameter = new SqlParameter[]
                {
                    new SqlParameter("@email", accountDto.Email),
                    new SqlParameter("@password", accountDto.Password),
                    new SqlParameter("@isAdmin", accountDto.IsAdmin),

                };

                using (IDataReader reader =
                    DatabaseProvider.ExecuteCommand<IDataReader>(connection, ADDACCOUNT, CommandType.StoredProcedure, parameter))
                {
                    if (reader.Read())
                    {

                        return int.Parse(reader["Id"].ToString());
                    }
                    return 0;
                }
            }
        }

        public void AddStudent(StudentDto studentDto)
        {
            using (SqlConnection connection = DatabaseProvider.GetSqlConnection())
            {
                SqlParameter[] parameter = new SqlParameter[]
                {
                    new SqlParameter("@accountId", studentDto.Account.Id),
                    new SqlParameter("@groupId", studentDto.Group.Id),
                    new SqlParameter("@langId", studentDto.ForeignLanguage.Id)
                };

                using (IDataReader reader =
                    DatabaseProvider.ExecuteCommand<IDataReader>(connection, ADDSTUDENT, CommandType.StoredProcedure, parameter))
                {
                    /*if (reader.Read())
                    {

                        /*return int.Parse(reader["Id"].ToString());#1#
                    }
                    return 0;*/
                }
            }
        }
    }
}
