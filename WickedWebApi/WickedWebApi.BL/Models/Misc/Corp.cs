using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WickedWebApi.BL.Models.Misc
{
    public class Corp
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public List<string> Sali { get; set; }
    }
}
