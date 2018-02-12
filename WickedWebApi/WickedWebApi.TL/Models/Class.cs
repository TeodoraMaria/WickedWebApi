using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WickedWebApi.BL.Models
{
    public class Class
    {
        public int Id { get; set; }
        public Subject Subject { get; set; }
        public ClassType TipMaterie { get; set; }
    }
}
