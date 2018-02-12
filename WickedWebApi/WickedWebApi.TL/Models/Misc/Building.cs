using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WickedWebApi.BL.Models.Misc
{
    public class Building
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> ClassRoom { get; set; }
    }
}
