using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickedWebApi.BL.Models;
using WickedWebApi.TL.Models;

namespace WickedWebApi.DAL.Student
{
    public class StudentRepository :IStudentRepository
    {
        private const string GETAPPOINTMENTS = "GetAppointmentsForStudent";

        public IList<AppointmentDto> GetAllAppointmentDtosForStudentDto(int studentId)
        {
            IList<AppointmentDto> feedbacks = new List<AppointmentDto>();
            using (SqlConnection connection = DatabaseProvider.GetSqlConnection())
            {
                SqlParameter[] parameters = { new SqlParameter("@id", studentId) };

                using (IDataReader reader =
                    DatabaseProvider.ExecuteCommand<IDataReader>(connection, GETAPPOINTMENTS, CommandType.StoredProcedure, parameters))
                {
                    while (reader.Read())
                    {
                        AppointmentDto app = DtoHelper.GetDto<AppointmentDto>(reader);
                        feedbacks.Add(app);
                    }
                }
            }

            return feedbacks;
        }
        
    }
}
