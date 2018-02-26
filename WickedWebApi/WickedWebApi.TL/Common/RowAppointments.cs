using System.Collections.Generic;

namespace WickedWebApi.TL.Common
{
    public class RowAppointments
    {
        public string Group { get; set; }
        public string SemiGroup { get; set; }
        public RowAppointments()
        {
        }

        public List<AppointmentExcelRead> AppointmentExcelReads { get; set; }
    }
}
