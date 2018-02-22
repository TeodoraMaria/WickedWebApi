using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WickedWebApi.BL.Models
{
    public enum ClassTypeEnum
    {
        S,
        C,
        L,
        E,
        
    }

    public class ClassTypeEnumExtension
    {
        public static ClassTypeEnum StringToEnum(string s)
        {
            switch (s)
            {
                case "S": return ClassTypeEnum.S;
                case "C": return ClassTypeEnum.C;
                case "L": return ClassTypeEnum.L;
                case "E": return ClassTypeEnum.E;
                default: return ClassTypeEnum.E;
            }
        }
    }
       
}
