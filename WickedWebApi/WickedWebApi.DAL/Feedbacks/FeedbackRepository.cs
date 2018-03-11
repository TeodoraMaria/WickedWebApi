using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WickedWebApi.TL.Models;

namespace WickedWebApi.DAL.Feedbacks
{
    public class FeedbackRepository: IFeedbackRepository
    {
        private const string ADD = "AddFeedback";
        private const string GETFEEDBACKS = "GetAllFeedbacksForActualClass";

        public int AddFeedback(FeedbackDto feedback)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@actualClassId", feedback.ActualClass.Id),
                    new SqlParameter("@usefulness", feedback.Usefulness),
                    new SqlParameter("@novelty", feedback.Novelty),
                    new SqlParameter("@highScientificLevel", feedback.HighScientificLevel),
                    new SqlParameter("@rigorousScientificLevel",feedback.RigorousScientificLevel),
                    new SqlParameter("@attractivenes", feedback.Attractiveness),
                    new SqlParameter("@clearness", feedback.Clearness),
                    new SqlParameter("@correctness", feedback.Correctness),
                    new SqlParameter("@interactivity", feedback.Interactivity),
                    new SqlParameter("@comprehension", feedback.Comprehension),
                    new SqlParameter("@comment", feedback.Comment)
                };

            return DatabaseProvider.ExecuteCommand<int>(DatabaseProvider.GetSqlConnection(),ADD, CommandType.StoredProcedure, parameters);
        }

        public IList<FeedbackDto> GetAllFeedbacksForActualClass(int classId)
        {
            IList<FeedbackDto> feedbacks = new List<FeedbackDto>();
            using (SqlConnection connection = DatabaseProvider.GetSqlConnection())
            {
                SqlParameter[] parameters = { new SqlParameter("@actualClassId", classId) };

                using (IDataReader reader =
                    DatabaseProvider.ExecuteCommand<IDataReader>(connection, GETFEEDBACKS, CommandType.StoredProcedure, parameters))
                {
                    while (reader.Read())
                    {
                        FeedbackDto fb = DtoHelper.GetDto<FeedbackDto>(reader);
                        feedbacks.Add(fb);
                    }
                }
            }

            return feedbacks;
        }
    }
}
