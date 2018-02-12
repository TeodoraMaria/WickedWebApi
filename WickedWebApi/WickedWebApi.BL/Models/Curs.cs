using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WickedWebApi.BL.Models
{
    public class Curs
    {
        public int Id { get; set; }
        public Materie Materie { get; set; }
        public TipMaterie TipMaterie { get; set; }
    }
}
