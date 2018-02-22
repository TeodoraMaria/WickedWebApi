using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickedWebApi.BL.Models;

namespace WickedWebApi.BL
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
