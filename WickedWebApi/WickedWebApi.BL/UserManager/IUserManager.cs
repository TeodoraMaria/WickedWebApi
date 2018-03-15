
using System.Collections.Generic;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using WickedWebApi.BL.Models;
using WickedWebApi.TL.Common;

namespace WickedWebApi.BL.AccountManager
{
   public interface IUserManager
   {
      bool CheckEmail(string email);
      int LogIn(string email, string password);
      int Register(string email, string password, string foreignLanguage);

       List<AppointmentDto> GetAppointmentDtosForStudentDto(TimeTable timeTable,StudentDto studentDto);

       AppointmentDto GetNextAppointmentDtoForStudentDto(List<AppointmentDto> appointmentDtos, StudentDto studentDto);
   }
}
