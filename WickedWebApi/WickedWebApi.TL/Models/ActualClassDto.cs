using System;
using WickedWebApi.BL.Models;

namespace WickedWebApi.TL.Models
{
    public class ActualClassDto
    {
        public int Id { get; set; }
        public ClassDto Class { get; set; }
        public DateTime Date { get; set; } 
    }
}
