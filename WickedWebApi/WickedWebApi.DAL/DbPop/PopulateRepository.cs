using System.Data;
using System.Data.SqlClient;
using WickedWebApi.BL.Models;

namespace WickedWebApi.DAL.DbPop
{
    public class PopulateRepository:IPopulateRepository
    {
        private const string ADDGROUP = "AddGroup";
        private const string ADDACCOUNT = "AddAccount";
        private const string ADDSTUDENT = "AddStudent";
        private const string ADDSUBJECT = "AddSubject";
        private const string ADDCLASS = "AddClass";
        private const string ADDTEACHER = "AddTeacher";
        private const string ADDAPPOINTMENT = "AddAppointment";

        private const string GETACCOUNTIDBYTEACHERNAME = "GetAccountByTeacherName";

        public int GetAccountIdByTeacherName(string name)
        {
            using (SqlConnection connection = DatabaseProvider.GetSqlConnection())
            {
                SqlParameter parameters =  new SqlParameter("@teacherName", name);

                using (IDataReader reader =
                    DatabaseProvider.ExecuteCommand<IDataReader>(connection, GETACCOUNTIDBYTEACHERNAME, CommandType.StoredProcedure, parameters))
                {
                    if (reader.Read())
                    {

                        return int.Parse(reader["Id"].ToString());
                    }
                    return 0;
                }
            }
        }


        public int AddAppointment(AppointmentDto appointmentDto)
        {
            using (SqlConnection connection = DatabaseProvider.GetSqlConnection())
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@class", appointmentDto.Class.Id), new SqlParameter("@group", appointmentDto.Group.Id),
                    new SqlParameter("@teacher", appointmentDto.Teacher.Id), new SqlParameter("@classroom", appointmentDto.ClassRoom),
                    new SqlParameter("@hour", appointmentDto.Hours),new SqlParameter("@day", appointmentDto.Day),
                };

                using (IDataReader reader =
                    DatabaseProvider.ExecuteCommand<IDataReader>(connection, ADDAPPOINTMENT, CommandType.StoredProcedure, parameters))
                {
                    if (reader.Read())
                    {

                        return int.Parse(reader["Id"].ToString());
                    }
                    return 0;
                }
            }
        }

        public int AddTeacher(TeacherDto teacher)
        {
            using(SqlConnection connection = DatabaseProvider.GetSqlConnection())
            {
                SqlParameter[] parameters = { new SqlParameter("@name", teacher.Name), new SqlParameter("@account", teacher.Account.Id) };

                using (IDataReader reader =
                   DatabaseProvider.ExecuteCommand<IDataReader>(connection, ADDTEACHER, CommandType.StoredProcedure, parameters))
                {
                    if (reader.Read())
                    {

                        return int.Parse(reader["Id"].ToString());
                    }
                    return 0;
                }
            }
        }

        public int AddClass(ClassDto classDto)
        {
            using (SqlConnection connection = DatabaseProvider.GetSqlConnection())
            {
                int type = 0;
                switch (classDto.ClassType)
                {
                    case ClassTypeEnum.S:
                        type = 1;
                        break;
                    case ClassTypeEnum.C:
                        type = 2;
                        break;
                    case ClassTypeEnum.L:
                        type = 3;
                        break;
                    case ClassTypeEnum.E:
                        type = 4;
                        break;
                    default:
                        break;
                }

                SqlParameter[] parameters = { new SqlParameter("@subject", classDto.Subject.Id), new SqlParameter("@type", type) };


                using (IDataReader reader =
                    DatabaseProvider.ExecuteCommand<IDataReader>(connection, ADDCLASS, CommandType.StoredProcedure, parameters))
                {
                    if (reader.Read())
                    {

                        return int.Parse(reader["Id"].ToString());
                    }
                    return 0;
                }
            }
        }

        public int AddSubject(SubjectDto subject)
        {
            using (SqlConnection connection = DatabaseProvider.GetSqlConnection())
            {
                SqlParameter parameter = new SqlParameter("@name", subject.Name);


                using (IDataReader reader =
                    DatabaseProvider.ExecuteCommand<IDataReader>(connection, ADDSUBJECT, CommandType.StoredProcedure, parameter))
                {
                    if (reader.Read())
                    {

                        return int.Parse(reader["Id"].ToString());
                    }
                    return 0;
                }
            }
        }

        public int AddGroup(GroupDto group)
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
