using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickedWebApi.BL.Models.Misc;

namespace WickedWebApi.BL.Models
{
    public class Programare
    {
        public Programare(int id, Curs curs, Profesor profesor, DateTime data, Corp corp, string sala, Grupa grupa)
        {
            Id = id;
            Curs = curs;
            Profesor = profesor;
            Data = data;
            Corp = corp;
            Sala = sala;
            Grupa = grupa;
        }

        public int Id { get; set; }
        public Curs Curs { get; set; }
        public Profesor Profesor { get; set; }
        public DateTime Data { get; set; }
        public Corp Corp { get; set; }
        public string Sala { get; set; }
        public Grupa Grupa { get; set; }
    }
}
