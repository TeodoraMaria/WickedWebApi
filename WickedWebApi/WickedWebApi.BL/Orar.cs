using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickedWebApi.BL.Models;

namespace WickedWebApi.BL
{
    public class Orar
    {
        public Orar()
        {
            Grupe = new List<Grupa>();
            Programare = new List<Programare>();
        }

        public List<Grupa> Grupe { get; set; }
        public List<Programare> Programare { get; set; }
        public List<Materie> Materii { get; set; }
        public List<Profesor> Profesori { get; set; }
        //public List<>
    }
}
